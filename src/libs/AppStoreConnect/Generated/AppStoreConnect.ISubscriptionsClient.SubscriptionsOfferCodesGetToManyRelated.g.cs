#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodeCustomCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodePrices"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitOneTimeUseCodes"></param>
        /// <param name="limitCustomCodes"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionOfferCodesResponse> SubscriptionsOfferCodesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode>? fieldsSubscriptionOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode>? fieldsSubscriptionOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice>? fieldsSubscriptionOfferCodePrices = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem>? include = default,
            int? limitOneTimeUseCodes = default,
            int? limitCustomCodes = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsSubscriptionOfferCodes"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodeCustomCodes"></param>
        /// <param name="fieldsSubscriptionOfferCodePrices"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitOneTimeUseCodes"></param>
        /// <param name="limitCustomCodes"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionOfferCodesResponse>> SubscriptionsOfferCodesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode>? fieldsSubscriptionOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeOneTimeUseCode>? fieldsSubscriptionOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeCustomCode>? fieldsSubscriptionOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodePrice>? fieldsSubscriptionOfferCodePrices = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsOfferCodesGetToManyRelatedIncludeItem>? include = default,
            int? limitOneTimeUseCodes = default,
            int? limitCustomCodes = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}