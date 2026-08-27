#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionOfferCodesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionOfferCodeCustomCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionOfferCodeCustomCodesResponse> SubscriptionOfferCodesCustomCodesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode>? fieldsSubscriptionOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesCustomCodesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionOfferCodeCustomCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionOfferCodeCustomCodesResponse>> SubscriptionOfferCodesCustomCodesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode>? fieldsSubscriptionOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionOfferCodesCustomCodesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}