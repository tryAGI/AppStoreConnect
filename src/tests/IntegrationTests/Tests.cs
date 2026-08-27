namespace AppStoreConnect.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static AppStoreConnectClient GetAuthenticatedClient()
    {
        var jwt =
            Environment.GetEnvironmentVariable("APP_STORE_CONNECT_JWT") is { Length: > 0 } jwtValue
                ? jwtValue
                : throw new AssertInconclusiveException("APP_STORE_CONNECT_JWT environment variable is not found.");

        var client = AppStoreConnectClientFactory.Create(jwt);
        
        return client;
    }
}
