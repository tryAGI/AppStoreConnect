using System.Buffers;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace AppStoreConnect;

/// <summary>
/// Creates the short-lived ES256 JSON Web Tokens required by App Store Connect.
/// </summary>
public sealed class AppStoreConnectCredential
{
    /// <summary>
    /// Apple's maximum accepted token lifetime.
    /// </summary>
    public static readonly TimeSpan MaximumTokenLifetime = TimeSpan.FromMinutes(20);

    private static readonly TimeSpan DefaultTokenLifetime = TimeSpan.FromMinutes(19);

    private readonly string _privateKeyPem;

    /// <summary>
    /// Creates an App Store Connect credential from an API key issuer, key identifier, and PKCS#8 PEM private key.
    /// </summary>
    public AppStoreConnectCredential(string issuerId, string keyId, string privateKeyPem)
    {
        IssuerId = RequireValue(issuerId, nameof(issuerId));
        KeyId = RequireValue(keyId, nameof(keyId));
        _privateKeyPem = RequireValue(privateKeyPem, nameof(privateKeyPem));
    }

    /// <summary>
    /// App Store Connect issuer identifier.
    /// </summary>
    public string IssuerId { get; }

    /// <summary>
    /// App Store Connect API key identifier.
    /// </summary>
    public string KeyId { get; }

    /// <summary>
    /// Creates a signed ES256 bearer token.
    /// </summary>
    public string CreateToken(DateTimeOffset issuedAt, TimeSpan? lifetime = null)
    {
        var effectiveLifetime = lifetime ?? DefaultTokenLifetime;
        if (effectiveLifetime <= TimeSpan.Zero || effectiveLifetime > MaximumTokenLifetime)
        {
            throw new ArgumentOutOfRangeException(
                nameof(lifetime),
                effectiveLifetime,
                $"App Store Connect token lifetime must be greater than zero and no more than {MaximumTokenLifetime.TotalMinutes:0} minutes.");
        }

        var header = WriteJson(static (writer, state) =>
        {
            writer.WriteStartObject();
            writer.WriteString("alg", "ES256");
            writer.WriteString("kid", state.KeyId);
            writer.WriteString("typ", "JWT");
            writer.WriteEndObject();
        }, this);

        var payload = WriteJson(static (writer, state) =>
        {
            writer.WriteStartObject();
            writer.WriteString("iss", state.Credential.IssuerId);
            writer.WriteNumber("iat", state.IssuedAt.ToUnixTimeSeconds());
            writer.WriteNumber("exp", state.IssuedAt.Add(state.Lifetime).ToUnixTimeSeconds());
            writer.WriteString("aud", "appstoreconnect-v1");
            writer.WriteEndObject();
        }, (Credential: this, IssuedAt: issuedAt, Lifetime: effectiveLifetime));

        var signingInput = $"{Base64UrlEncode(header)}.{Base64UrlEncode(payload)}";

        using var algorithm = ECDsa.Create();
        algorithm.ImportFromPem(_privateKeyPem);
        if (algorithm.KeySize != 256)
        {
            throw new CryptographicException($"App Store Connect requires a P-256 private key, but the imported key size is {algorithm.KeySize} bits.");
        }

        var signature = algorithm.SignData(
            Encoding.ASCII.GetBytes(signingInput),
            HashAlgorithmName.SHA256,
            DSASignatureFormat.IeeeP1363FixedFieldConcatenation);

        return $"{signingInput}.{Base64UrlEncode(signature)}";
    }

    private static byte[] WriteJson<TState>(Action<Utf8JsonWriter, TState> write, TState state)
    {
        var buffer = new ArrayBufferWriter<byte>();
        using (var writer = new Utf8JsonWriter(buffer))
        {
            write(writer, state);
        }

        return buffer.WrittenSpan.ToArray();
    }

    private static string Base64UrlEncode(ReadOnlySpan<byte> value) =>
        Convert.ToBase64String(value)
            .TrimEnd('=')
            .Replace('+', '-')
            .Replace('/', '_');

    private static string RequireValue(string value, string parameterName) =>
        string.IsNullOrWhiteSpace(value)
            ? throw new ArgumentException("Value cannot be null, empty, or whitespace.", parameterName)
            : value;
}
