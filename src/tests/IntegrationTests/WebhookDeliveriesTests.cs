using System.Net;
using System.Text;

namespace AppStoreConnect.IntegrationTests;

[TestClass]
public sealed class WebhookDeliveriesTests
{
    [TestMethod]
    public async Task GetDeliveriesSinceAsync_SendsOnlyRequiredDateFilter()
    {
        var handler = new RecordingHandler();
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://example.test/"),
        };
        using var client = AppStoreConnectClientFactory.Create("signed-token", httpClient, disposeHttpClient: false);

        WebhookDeliveriesResponse response = await client.Webhooks.GetDeliveriesSinceAsync(
            "webhook-id",
            new DateTimeOffset(2026, 9, 1, 12, 34, 56, TimeSpan.FromHours(4)),
            limit: 200);

        response.Data.Should().BeEmpty();
        handler.RequestUri.Should().NotBeNull();
        handler.RequestUri!.AbsolutePath.Should().Be("/v1/webhooks/webhook-id/deliveries");
        handler.RequestUri.Query.Should().Contain("filter%5BcreatedDateGreaterThanOrEqualTo%5D=2026-09-01T08%3A34%3A56Z");
        handler.RequestUri.Query.Should().Contain("limit=200");
        handler.RequestUri.Query.Should().NotContain("deliveryState");
        handler.RequestUri.Query.Should().NotContain("createdDateLessThan");
    }

    [TestMethod]
    public async Task GeneratedDeliveryMethod_RejectsUnsupportedFilterShapesBeforeSending()
    {
        var handler = new RecordingHandler();
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://example.test/"),
        };
        using var client = AppStoreConnectClientFactory.Create("signed-token", httpClient, disposeHttpClient: false);

        Func<Task> missingDateFilter = () =>
            client.Webhooks.WebhooksDeliveriesGetToManyRelatedAsync("webhook-id");
        Func<Task> additionalStateFilter = () =>
            client.Webhooks.WebhooksDeliveriesGetToManyRelatedAsync(
                "webhook-id",
                filterDeliveryState: [WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem.Failed],
                filterCreatedDateGreaterThanOrEqualTo: ["2026-09-01T00:00:00Z"]);

        await missingDateFilter.Should().ThrowAsync<ArgumentException>();
        await additionalStateFilter.Should().ThrowAsync<ArgumentException>();
        handler.RequestCount.Should().Be(0);
    }

    private sealed class RecordingHandler : HttpMessageHandler
    {
        public Uri? RequestUri { get; private set; }

        public int RequestCount { get; private set; }

        protected override Task<HttpResponseMessage> SendAsync(
            HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            RequestCount++;
            RequestUri = request.RequestUri;

            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent(
                    """{"data":[],"links":{"self":"https://example.test/v1/webhooks/webhook-id/deliveries"}}""",
                    Encoding.UTF8,
                    "application/json"),
            });
        }
    }
}
