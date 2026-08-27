#nullable enable

namespace AppStoreConnect
{
    public partial interface IWebhooksClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterDeliveryState"></param>
        /// <param name="filterCreatedDateGreaterThanOrEqualTo"></param>
        /// <param name="filterCreatedDateLessThan"></param>
        /// <param name="fieldsWebhookDeliveries"></param>
        /// <param name="fieldsWebhookEvents"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.WebhookDeliveriesResponse> WebhooksDeliveriesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem>? filterDeliveryState = default,
            global::System.Collections.Generic.IList<string>? filterCreatedDateGreaterThanOrEqualTo = default,
            global::System.Collections.Generic.IList<string>? filterCreatedDateLessThan = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie>? fieldsWebhookDeliveries = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent>? fieldsWebhookEvents = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterDeliveryState"></param>
        /// <param name="filterCreatedDateGreaterThanOrEqualTo"></param>
        /// <param name="filterCreatedDateLessThan"></param>
        /// <param name="fieldsWebhookDeliveries"></param>
        /// <param name="fieldsWebhookEvents"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.WebhookDeliveriesResponse>> WebhooksDeliveriesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFilterDeliveryStateItem>? filterDeliveryState = default,
            global::System.Collections.Generic.IList<string>? filterCreatedDateGreaterThanOrEqualTo = default,
            global::System.Collections.Generic.IList<string>? filterCreatedDateLessThan = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookDeliverie>? fieldsWebhookDeliveries = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedFieldsWebhookEvent>? fieldsWebhookEvents = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.WebhooksDeliveriesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}