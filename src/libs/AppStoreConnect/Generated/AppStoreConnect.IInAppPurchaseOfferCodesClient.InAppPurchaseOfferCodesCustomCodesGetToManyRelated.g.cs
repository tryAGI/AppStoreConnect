#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseOfferCodesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseOfferCodeCustomCodes"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodesResponse> InAppPurchaseOfferCodesCustomCodesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode>? fieldsInAppPurchaseOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor>? fieldsActors = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseOfferCodeCustomCodes"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseOfferCodeCustomCodesResponse>> InAppPurchaseOfferCodesCustomCodesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode>? fieldsInAppPurchaseOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedFieldsActor>? fieldsActors = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesCustomCodesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}