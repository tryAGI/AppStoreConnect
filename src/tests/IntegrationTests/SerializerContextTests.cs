using System.Text.Json;

namespace AppStoreConnect.IntegrationTests;

[TestClass]
public sealed class SerializerContextTests
{
    [TestMethod]
    public void AllGeneratedClrTypesLoad()
    {
        typeof(AppStoreConnectClient).Assembly.GetTypes().Length.Should().BeGreaterThan(1000);
    }

    [TestMethod]
    public void ResponseMetadataRoundTripPreservesEnumsAndDynamicFields()
    {
        var response = BetaTesterInvitationResponse.FromJson(
            """{"data":{"type":"betaTesterInvitations","id":"offline-invitation","future_flag":false},"links":{"self":"https://example.test/invitation"}}""")
            ?? throw new InvalidOperationException("Response did not deserialize.");
        using var document = JsonDocument.Parse(response.ToJson());
        var data = document.RootElement.GetProperty("data");
        data.GetProperty("type").GetString().Should().Be("betaTesterInvitations");
        data.GetProperty("id").GetString().Should().Be("offline-invitation");
        data.GetProperty("future_flag").GetBoolean().Should().BeFalse();
    }

    [TestMethod]
    public void DirectTagContext_ResolvesTypesFromAggregateContext()
    {
        var context = BetaTesterInvitationsSourceGenerationContext.Default;

        context.GetTypeInfo(typeof(BetaTesterInvitationResponse)).Should().NotBeNull();

        var values = JsonSerializer.Deserialize(
            """{"id":"invitation-id"}""",
            typeof(Dictionary<string, string>),
            context) as Dictionary<string, string>;

        values.Should().ContainKey("id").WhoseValue.Should().Be("invitation-id");
    }
}
