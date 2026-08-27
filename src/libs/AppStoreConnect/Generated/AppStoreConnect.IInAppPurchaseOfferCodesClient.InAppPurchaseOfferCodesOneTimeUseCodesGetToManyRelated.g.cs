#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseOfferCodesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCodesResponse> InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode>? fieldsInAppPurchaseOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor>? fieldsActors = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseOfferCodeOneTimeUseCodesResponse>> InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode>? fieldsInAppPurchaseOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedFieldsActor>? fieldsActors = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseOfferCodesOneTimeUseCodesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}