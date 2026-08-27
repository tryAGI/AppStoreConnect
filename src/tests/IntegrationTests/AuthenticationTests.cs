using System.Net;
using System.Security.Cryptography;
using System.Text.Json;

namespace AppStoreConnect.IntegrationTests;

[TestClass]
public sealed class AuthenticationTests
{
    [TestMethod]
    public void CreateToken_ProducesVerifiableAppleJwt()
    {
        using var algorithm = ECDsa.Create(ECCurve.NamedCurves.nistP256);
        var credential = new AppStoreConnectCredential(
            "issuer-id",
            "key-id",
            algorithm.ExportPkcs8PrivateKeyPem());
        var issuedAt = new DateTimeOffset(2026, 8, 27, 0, 0, 0, TimeSpan.Zero);

        var token = credential.CreateToken(issuedAt, TimeSpan.FromMinutes(10));
        var segments = token.Split('.');

        segments.Should().HaveCount(3);
        using var header = JsonDocument.Parse(Base64UrlDecode(segments[0]));
        using var payload = JsonDocument.Parse(Base64UrlDecode(segments[1]));
        header.RootElement.GetProperty("alg").GetString().Should().Be("ES256");
        header.RootElement.GetProperty("kid").GetString().Should().Be("key-id");
        payload.RootElement.GetProperty("iss").GetString().Should().Be("issuer-id");
        payload.RootElement.GetProperty("aud").GetString().Should().Be("appstoreconnect-v1");
        payload.RootElement.GetProperty("iat").GetInt64().Should().Be(issuedAt.ToUnixTimeSeconds());
        payload.RootElement.GetProperty("exp").GetInt64().Should().Be(issuedAt.AddMinutes(10).ToUnixTimeSeconds());

        algorithm.VerifyData(
                System.Text.Encoding.ASCII.GetBytes($"{segments[0]}.{segments[1]}"),
                Base64UrlDecode(segments[2]),
                HashAlgorithmName.SHA256,
                DSASignatureFormat.IeeeP1363FixedFieldConcatenation)
            .Should().BeTrue();
    }

    [TestMethod]
    public void CreateToken_RejectsLifetimeBeyondAppleLimit()
    {
        using var algorithm = ECDsa.Create(ECCurve.NamedCurves.nistP256);
        var credential = new AppStoreConnectCredential("issuer", "key", algorithm.ExportPkcs8PrivateKeyPem());

        var action = () => credential.CreateToken(DateTimeOffset.UtcNow, TimeSpan.FromMinutes(21));

        action.Should().Throw<ArgumentOutOfRangeException>();
    }

    [TestMethod]
    public async Task CredentialFactory_RefreshesBearerTokenForEveryRequest()
    {
        using var algorithm = ECDsa.Create(ECCurve.NamedCurves.nistP256);
        var credential = new AppStoreConnectCredential("issuer", "key", algorithm.ExportPkcs8PrivateKeyPem());
        var timeProvider = new MutableTimeProvider(new DateTimeOffset(2026, 8, 27, 0, 0, 0, TimeSpan.Zero));
        var handler = new RecordingHandler();
        using var client = AppStoreConnectClientFactory.Create(credential, handler, timeProvider);

        await client.HttpClient.GetAsync("v1/first");
        timeProvider.Advance(TimeSpan.FromMinutes(1));
        await client.HttpClient.GetAsync("v1/second");

        handler.BearerTokens.Should().HaveCount(2);
        handler.BearerTokens[0].Should().NotBe(handler.BearerTokens[1]);
    }

    [TestMethod]
    public void TokenFactory_ConfiguresGeneratedBearerAuthorization()
    {
        using var client = AppStoreConnectClientFactory.Create("signed-token");

        client.Authorizations.Should().ContainSingle();
        client.Authorizations[0].Type.Should().Be("Http");
        client.Authorizations[0].Name.Should().Be("Bearer");
        client.Authorizations[0].Value.Should().Be("signed-token");
    }

    private static byte[] Base64UrlDecode(string value)
    {
        var padded = value.Replace('-', '+').Replace('_', '/');
        padded = padded.PadRight(padded.Length + ((4 - padded.Length % 4) % 4), '=');
        return Convert.FromBase64String(padded);
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        public List<string> BearerTokens { get; } = [];

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            BearerTokens.Add(request.Headers.Authorization?.Parameter ?? string.Empty);
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK));
        }
    }

    private sealed class MutableTimeProvider(DateTimeOffset value) : TimeProvider
    {
        private DateTimeOffset _value = value;

        public override DateTimeOffset GetUtcNow() => _value;

        public void Advance(TimeSpan duration) => _value += duration;
    }
}
