// MIT. Upload journal/data-plane implementation ported from HavenDV/Advantage.
using System.Buffers;
using System.Diagnostics;
using System.Net;
using Microsoft.Win32.SafeHandles;

namespace AppStoreConnect.Uploads;

/// <summary>Transfers only Apple's signed, contiguous upload operations. Shared by CLI and backend.</summary>
internal static class AppleBuildUploadTransfer
{
    // Each connection streams a bounded 64 KiB buffer, not an entire package part.
    internal const int MaxParallelism = 32;
    internal sealed record Header(string Name, string Value);
    internal sealed record Operation(long Offset, long Length, string Method, string Url, IReadOnlyList<Header> Headers);
    internal sealed record Checkpoint(long Offset, long Length);
    internal sealed record Part(int Number, long Bytes, int Attempts, double Seconds, string Host, string Protocol);
    internal sealed record Result(long Bytes, double Seconds, double Mbps, int Retries, IReadOnlyList<Part> Parts);

    internal sealed class TransferException : IOException
    {
        public TransferException() { }
        public TransferException(string message) : base(message) { }
        public TransferException(string message, Exception innerException) : base(message, innerException) { }
        public TransferException(HttpStatusCode statusCode) : base($"Apple transfer returned HTTP {(int)statusCode}.") => StatusCode = statusCode;
        public HttpStatusCode StatusCode { get; }
    }

    internal static HttpClient CreateClient(int parallelism)
    {
        SocketsHttpHandler? handler = null;
        HttpClient client;
        try
        {
            handler = new SocketsHttpHandler();
            handler.AllowAutoRedirect = false;
            handler.UseCookies = false;
            handler.MaxConnectionsPerServer = Math.Clamp(parallelism, 1, MaxParallelism);
            handler.ConnectTimeout = TimeSpan.FromSeconds(20);
            handler.PooledConnectionLifetime = TimeSpan.FromMinutes(10);
            client = new HttpClient(handler, disposeHandler: true);
            handler = null;
        }
        finally
        {
            handler?.Dispose();
        }
        try
        {
            client.Timeout = Timeout.InfiniteTimeSpan;
            return client;
        }
        catch
        {
            client.Dispose();
            throw;
        }
    }

    internal static void Validate(IReadOnlyList<Operation> operations, long size, string? expectedHost = null)
    {
        if (size <= 0 || operations.Count is 0 or > 10000)
            throw new InvalidDataException("Missing file bytes or invalid Apple operation count.");
        long cursor = 0;
        foreach (var operation in operations.OrderBy(x => x.Offset))
        {
            if (operation.Offset != cursor || operation.Length <= 0 || operation.Length > size - cursor)
                throw new InvalidDataException("Apple upload operations do not cover the file exactly once.");
            cursor += operation.Length;
            if (operation.Method != "PUT" || !Uri.TryCreate(operation.Url, UriKind.Absolute, out var uri)
                || uri.Scheme != Uri.UriSchemeHttps || !uri.IsDefaultPort || uri.UserInfo.Length != 0
                || uri.Fragment.Length != 0 || !uri.IdnHost.EndsWith(".apple.com", StringComparison.OrdinalIgnoreCase))
                throw new InvalidDataException("Apple upload must use an Apple-issued HTTPS PUT URL; endpoint rewriting is forbidden.");
            if (expectedHost is not null && !string.Equals(uri.IdnHost, expectedHost, StringComparison.OrdinalIgnoreCase))
                throw new InvalidDataException("The Apple-assigned upload host does not match the required host.");
            foreach (var header in operation.Headers)
            {
                if (string.IsNullOrWhiteSpace(header.Name) || header.Name.Contains('\r') || header.Name.Contains('\n')
                    || header.Value.Contains('\r') || header.Value.Contains('\n')
                    || header.Name.Equals("Host", StringComparison.OrdinalIgnoreCase)
                    || header.Name.Equals("Transfer-Encoding", StringComparison.OrdinalIgnoreCase))
                    throw new InvalidDataException("Unsafe upload header in Apple reservation.");
            }
        }
        if (cursor != size) throw new InvalidDataException("Apple upload operations leave missing bytes.");
    }

    internal static async Task<Result> UploadAsync(HttpClient client, string path, long size,
        IReadOnlyList<Operation> operations, int parallelism, Action<Part>? progress, CancellationToken ct,
        string? expectedHost = null, FileStream? capturedInput = null,
        IReadOnlyList<Checkpoint>? acknowledged = null, TimeProvider? timeProvider = null)
    {
        Validate(operations, size, expectedHost);
        var completed = (acknowledged ?? []).ToHashSet();
        if (completed.Count != (acknowledged?.Count ?? 0)
            || completed.Any(part => !operations.Any(op => op.Offset == part.Offset && op.Length == part.Length)))
            throw new InvalidDataException("Acknowledged ranges do not match the current Apple reservation.");
        // All ranges refer to one open inode, even if another process replaces the pathname.
        using var ownedInput = capturedInput is null
            ? new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read, 65536, FileOptions.Asynchronous | FileOptions.RandomAccess)
            : null;
        var source = capturedInput ?? ownedInput;
        if (source is null)
        {
            throw new InvalidOperationException("Upload input stream was not initialized.");
        }
        if (source.Length != size) throw new InvalidDataException("Upload input size changed before transfer.");
        if (parallelism is < 1 or > MaxParallelism) throw new ArgumentOutOfRangeException(nameof(parallelism));
        var clock = Stopwatch.StartNew();
        var results = new Part?[operations.Count];
        using var failed = CancellationTokenSource.CreateLinkedTokenSource(ct);
        using var slots = new SemaphoreSlim(parallelism);
        await Task.WhenAll(operations.Select(async (operation, index) =>
        {
            if (completed.Contains(new Checkpoint(operation.Offset, operation.Length))) return;
            await slots.WaitAsync(failed.Token).ConfigureAwait(false);
            try
            {
                var timer = Stopwatch.StartNew();
                for (var attempt = 1; ; attempt++)
                {
                    // Bound lack of progress, not total part duration. The command owns the overall deadline.
                    using var idle = new CancellationTokenSource(TimeSpan.FromMinutes(3), timeProvider ?? TimeProvider.System);
                    using var deadline = CancellationTokenSource.CreateLinkedTokenSource(failed.Token, idle.Token);
                    try
                    {
                        using var request = new HttpRequestMessage(HttpMethod.Put, operation.Url)
                        {
                            // Independent HTTP/1.1 connections avoid sharing one congestion window across all parts.
                            Version = HttpVersion.Version11,
                            VersionPolicy = HttpVersionPolicy.RequestVersionExact,
                            Content = new RangeContent(source.SafeFileHandle, operation.Offset, operation.Length,
                                () => idle.CancelAfter(TimeSpan.FromMinutes(3))),
                        };
                        request.Headers.ExpectContinue = false;
                        foreach (var header in operation.Headers)
                        {
                            if (header.Name.Equals("Content-Length", StringComparison.OrdinalIgnoreCase)) continue;
                            if (!request.Headers.TryAddWithoutValidation(header.Name, header.Value))
                            {
                                request.Content.Headers.Remove(header.Name);
                                if (!request.Content.Headers.TryAddWithoutValidation(header.Name, header.Value))
                                    throw new InvalidDataException("Unsupported Apple upload header.");
                            }
                        }
                        using var response = await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, deadline.Token).ConfigureAwait(false);
                        if (!response.IsSuccessStatusCode)
                        {
                            if (attempt < 3 && IsTransient(response.StatusCode))
                            {
                                var delay = response.Headers.RetryAfter?.Delta?.TotalSeconds ?? attempt;
                                await Task.Delay(TimeSpan.FromSeconds(Math.Clamp(delay, 1, 30)), failed.Token).ConfigureAwait(false);
                                continue;
                            }
                            throw new TransferException(response.StatusCode);
                        }
                        var part = new Part(index + 1, operation.Length, attempt, timer.Elapsed.TotalSeconds,
                            new Uri(operation.Url).IdnHost, response.Version.ToString());
                        results[index] = part;
                        progress?.Invoke(part);
                        break;
                    }
                    catch (Exception ex) when (attempt < 3 && !failed.IsCancellationRequested
                        && (ex is HttpRequestException || ex is OperationCanceledException))
                    {
                        await Task.Delay(TimeSpan.FromSeconds(attempt), failed.Token).ConfigureAwait(false);
                    }
                }
            }
            catch
            {
                await failed.CancelAsync().ConfigureAwait(false);
                throw;
            }
            finally { slots.Release(); }
        })).ConfigureAwait(false);
        var transferred = results.OfType<Part>().ToArray();
        var bytes = transferred.Sum(x => x.Bytes);
        return new(bytes, clock.Elapsed.TotalSeconds, bytes * 8d / 1_000_000 / clock.Elapsed.TotalSeconds,
            transferred.Sum(x => x.Attempts - 1), transferred);
    }

    private static bool IsTransient(HttpStatusCode code) => code is HttpStatusCode.RequestTimeout
        or HttpStatusCode.TooManyRequests or HttpStatusCode.InternalServerError or HttpStatusCode.BadGateway
        or HttpStatusCode.ServiceUnavailable or HttpStatusCode.GatewayTimeout;

    private sealed class RangeContent(SafeFileHandle handle, long offset, long length, Action progressed) : HttpContent
    {
        protected override bool TryComputeLength(out long result) { result = length; return true; }
        protected override Task SerializeToStreamAsync(Stream stream, TransportContext? context) => SerializeToStreamAsync(stream, context, CancellationToken.None);
        protected override async Task SerializeToStreamAsync(Stream stream, TransportContext? context, CancellationToken cancellationToken)
        {
            var buffer = ArrayPool<byte>.Shared.Rent(65536);
            try
            {
                var remaining = length;
                while (remaining > 0)
                {
                    var count = await RandomAccess.ReadAsync(handle, buffer.AsMemory(0, (int)Math.Min(remaining, buffer.Length)), offset + length - remaining, cancellationToken).ConfigureAwait(false);
                    if (count == 0) throw new EndOfStreamException("Upload input ended before its reserved range.");
                    await stream.WriteAsync(buffer.AsMemory(0, count), cancellationToken).ConfigureAwait(false);
                    progressed();
                    remaining -= count;
                }
            }
            finally { ArrayPool<byte>.Shared.Return(buffer); }
        }
    }
}
