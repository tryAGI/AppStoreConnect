using System.Globalization;

namespace AppStoreConnect;

public sealed partial class WebhooksClient
{
    /// <summary>
    /// Gets webhook deliveries created at or after <paramref name="createdAtOrAfter"/> using the
    /// only filter shape currently accepted by the live App Store Connect API.
    /// </summary>
    /// <remarks>
    /// Although Apple's OpenAPI document marks all delivery filters as optional, the live API
    /// requires exactly one <c>filter[createdDateGreaterThanOrEqualTo]</c> value and rejects the
    /// delivery-state and upper-date filters on this endpoint.
    /// </remarks>
    public Task<WebhookDeliveriesResponse> GetDeliveriesSinceAsync(
        string id,
        DateTimeOffset createdAtOrAfter,
        IList<WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie>? fieldsWebhookDeliveries = default,
        IList<WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent>? fieldsWebhookEvents = default,
        int? limit = default,
        IList<WebhooksDeliveriesGetToManyRelatedIncludeItem>? include = default,
        AutoSDKRequestOptions? requestOptions = default,
        CancellationToken cancellationToken = default) =>
        WebhooksDeliveriesGetToManyRelatedAsync(
            id: id,
            filterCreatedDateGreaterThanOrEqualTo:
            [createdAtOrAfter.UtcDateTime.ToString("yyyy-MM-dd'T'HH:mm:ss'Z'", CultureInfo.InvariantCulture)],
            fieldsWebhookDeliveries: fieldsWebhookDeliveries,
            fieldsWebhookEvents: fieldsWebhookEvents,
            limit: limit,
            include: include,
            requestOptions: requestOptions,
            cancellationToken: cancellationToken);

    [System.Diagnostics.CodeAnalysis.SuppressMessage(
        "Performance",
        "CA1822:Mark members as static",
        Justification = "Implements the generated instance partial-method contract.")]
    partial void PrepareWebhooksDeliveriesGetToManyRelatedArguments(
        HttpClient httpClient,
        IList<WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem>? filterDeliveryState,
        IList<string>? filterCreatedDateGreaterThanOrEqualTo,
        IList<string>? filterCreatedDateLessThan,
        IList<WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie>? fieldsWebhookDeliveries,
        IList<WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent>? fieldsWebhookEvents,
        ref int? limit,
        IList<WebhooksDeliveriesGetToManyRelatedIncludeItem>? include,
        ref string id)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(id);

        if (filterCreatedDateGreaterThanOrEqualTo is not { Count: 1 } ||
            string.IsNullOrWhiteSpace(filterCreatedDateGreaterThanOrEqualTo[0]))
        {
            throw new ArgumentException(
                "The live App Store Connect API requires exactly one created-date lower-bound filter.",
                nameof(filterCreatedDateGreaterThanOrEqualTo));
        }

        if (filterDeliveryState is { Count: > 0 } || filterCreatedDateLessThan is { Count: > 0 })
        {
            throw new ArgumentException(
                "The live App Store Connect API rejects additional delivery-state or created-date upper-bound filters.");
        }
    }
}
