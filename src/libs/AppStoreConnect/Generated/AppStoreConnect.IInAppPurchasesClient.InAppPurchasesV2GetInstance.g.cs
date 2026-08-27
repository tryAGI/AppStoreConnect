#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchasesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="fieldsInAppPurchasePricePoints"></param>
        /// <param name="fieldsInAppPurchaseContents"></param>
        /// <param name="fieldsInAppPurchaseAppStoreReviewScreenshots"></param>
        /// <param name="fieldsPromotedPurchases"></param>
        /// <param name="fieldsInAppPurchasePriceSchedules"></param>
        /// <param name="fieldsInAppPurchaseAvailabilities"></param>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchaseOfferCodes"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitInAppPurchaseLocalizations"></param>
        /// <param name="limitOfferCodes"></param>
        /// <param name="limitPricePoints"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseV2Response> InAppPurchasesV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint>? fieldsInAppPurchasePricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent>? fieldsInAppPurchaseContents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot>? fieldsInAppPurchaseAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule>? fieldsInAppPurchasePriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie>? fieldsInAppPurchaseAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode>? fieldsInAppPurchaseOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceIncludeItem>? include = default,
            int? limitImages = default,
            int? limitInAppPurchaseLocalizations = default,
            int? limitOfferCodes = default,
            int? limitPricePoints = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="fieldsInAppPurchasePricePoints"></param>
        /// <param name="fieldsInAppPurchaseContents"></param>
        /// <param name="fieldsInAppPurchaseAppStoreReviewScreenshots"></param>
        /// <param name="fieldsPromotedPurchases"></param>
        /// <param name="fieldsInAppPurchasePriceSchedules"></param>
        /// <param name="fieldsInAppPurchaseAvailabilities"></param>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchaseOfferCodes"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitInAppPurchaseLocalizations"></param>
        /// <param name="limitOfferCodes"></param>
        /// <param name="limitPricePoints"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseV2Response>> InAppPurchasesV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePricePoint>? fieldsInAppPurchasePricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseContent>? fieldsInAppPurchaseContents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAppStoreReviewScreenshot>? fieldsInAppPurchaseAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchasePriceSchedule>? fieldsInAppPurchasePriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseAvailabilitie>? fieldsInAppPurchaseAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseOfferCode>? fieldsInAppPurchaseOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2GetInstanceIncludeItem>? include = default,
            int? limitImages = default,
            int? limitInAppPurchaseLocalizations = default,
            int? limitOfferCodes = default,
            int? limitPricePoints = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}