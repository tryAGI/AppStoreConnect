using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace AppStoreConnect;

/// <summary>
/// Creates authenticated App Store Connect clients from either a ready bearer token or an Apple API private key.
/// </summary>
public static class AppStoreConnectClientFactory
{
    /// <summary>
    /// Creates a client using a caller-managed short-lived App Store Connect bearer token.
    /// </summary>
    public static AppStoreConnectClient Create(
        string bearerToken,
        HttpClient? httpClient = null,
        bool disposeHttpClient = true)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(bearerToken);

        return new AppStoreConnectClient(
            httpClient,
            baseUri: null,
            authorizations: CreateAuthorizations(bearerToken),
            disposeHttpClient: disposeHttpClient);
    }

    /// <summary>
    /// Creates a client that signs a fresh App Store Connect token for every HTTP request.
    /// </summary>
    [SuppressMessage(
        "Reliability",
        "CA2000:Dispose objects before losing scope",
        Justification = "The authentication handler is transferred to an owning HttpClient, with explicit disposal on every exceptional path.")]
    public static AppStoreConnectClient Create(
        AppStoreConnectCredential credential,
        HttpMessageHandler? innerHandler = null,
        TimeProvider? timeProvider = null)
    {
        ArgumentNullException.ThrowIfNull(credential);

        var effectiveTimeProvider = timeProvider ?? TimeProvider.System;
        var authenticationHandler = new AppStoreConnectAuthenticationHandler(credential, effectiveTimeProvider);
        try
        {
            authenticationHandler.InnerHandler = innerHandler ?? new SocketsHttpHandler();
        }
        catch
        {
            authenticationHandler.Dispose();
            throw;
        }

        HttpClient httpClient;
        try
        {
            httpClient = new HttpClient(authenticationHandler, disposeHandler: true);
        }
        catch
        {
            authenticationHandler.Dispose();
            throw;
        }

        try
        {
            var initialToken = credential.CreateToken(effectiveTimeProvider.GetUtcNow());
            return new AppStoreConnectClient(
                httpClient,
                baseUri: null,
                authorizations: CreateAuthorizations(initialToken),
                disposeHttpClient: true);
        }
        catch
        {
            httpClient.Dispose();
            throw;
        }
    }

    private static List<EndPointAuthorization> CreateAuthorizations(string bearerToken) =>
    [
        new EndPointAuthorization
        {
            Type = "Http",
            SchemeId = "HttpBearer",
            Location = "Header",
            Name = "Bearer",
            Value = bearerToken,
        },
    ];

    private sealed class AppStoreConnectAuthenticationHandler(
        AppStoreConnectCredential credential,
        TimeProvider timeProvider) : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue(
                "Bearer",
                credential.CreateToken(timeProvider.GetUtcNow()));

            return base.SendAsync(request, cancellationToken);
        }
    }
}
