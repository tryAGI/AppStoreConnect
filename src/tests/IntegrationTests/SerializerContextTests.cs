using System.Text.Json;

namespace AppStoreConnect.IntegrationTests;

[TestClass]
public sealed class SerializerContextTests
{
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
