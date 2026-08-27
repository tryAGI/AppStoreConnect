#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchasesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsInAppPurchaseOfferCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferCodeCustomCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferPrices"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitOneTimeUseCodes"></param>
        /// <param name="limitCustomCodes"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseOfferCodesResponse> InAppPurchasesV2OfferCodesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode>? fieldsInAppPurchaseOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode>? fieldsInAppPurchaseOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode>? fieldsInAppPurchaseOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferPrice>? fieldsInAppPurchaseOfferPrices = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem>? include = default,
            int? limitOneTimeUseCodes = default,
            int? limitCustomCodes = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsInAppPurchaseOfferCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferCodeOneTimeUseCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferCodeCustomCodes"></param>
        /// <param name="fieldsInAppPurchaseOfferPrices"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitOneTimeUseCodes"></param>
        /// <param name="limitCustomCodes"></param>
        /// <param name="limitPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseOfferCodesResponse>> InAppPurchasesV2OfferCodesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCode>? fieldsInAppPurchaseOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeOneTimeUseCode>? fieldsInAppPurchaseOfferCodeOneTimeUseCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferCodeCustomCode>? fieldsInAppPurchaseOfferCodeCustomCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2OfferCodesGetToManyRelatedFieldsInAppPurchaseOfferPrice>? fieldsInAppPurchaseOfferPrices = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2OfferCodesGetToManyRelatedIncludeItem>? include = default,
            int? limitOneTimeUseCodes = default,
            int? limitCustomCodes = default,
            int? limitPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}