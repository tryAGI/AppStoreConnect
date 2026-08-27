#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterProductId"></param>
        /// <param name="filterName"></param>
        /// <param name="filterState"></param>
        /// <param name="filterInAppPurchaseType"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="fieldsInAppPurchaseContents"></param>
        /// <param name="fieldsInAppPurchaseAppStoreReviewScreenshots"></param>
        /// <param name="fieldsPromotedPurchases"></param>
        /// <param name="fieldsInAppPurchasePriceSchedules"></param>
        /// <param name="fieldsInAppPurchaseAvailabilities"></param>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchaseOfferCodes"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitInAppPurchaseLocalizations"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitOfferCodes"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchasesV2Response> AppsInAppPurchasesV2GetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterProductId = default,
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem>? filterInAppPurchaseType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent>? fieldsInAppPurchaseContents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot>? fieldsInAppPurchaseAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule>? fieldsInAppPurchasePriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie>? fieldsInAppPurchaseAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode>? fieldsInAppPurchaseOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedIncludeItem>? include = default,
            int? limitInAppPurchaseLocalizations = default,
            int? limitImages = default,
            int? limitOfferCodes = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterProductId"></param>
        /// <param name="filterName"></param>
        /// <param name="filterState"></param>
        /// <param name="filterInAppPurchaseType"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="fieldsInAppPurchaseContents"></param>
        /// <param name="fieldsInAppPurchaseAppStoreReviewScreenshots"></param>
        /// <param name="fieldsPromotedPurchases"></param>
        /// <param name="fieldsInAppPurchasePriceSchedules"></param>
        /// <param name="fieldsInAppPurchaseAvailabilities"></param>
        /// <param name="fieldsInAppPurchaseImages"></param>
        /// <param name="fieldsInAppPurchaseOfferCodes"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitInAppPurchaseLocalizations"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitOfferCodes"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchasesV2Response>> AppsInAppPurchasesV2GetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterProductId = default,
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFilterInAppPurchaseTypeItem>? filterInAppPurchaseType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseContent>? fieldsInAppPurchaseContents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAppStoreReviewScreenshot>? fieldsInAppPurchaseAppStoreReviewScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchasePriceSchedule>? fieldsInAppPurchasePriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseAvailabilitie>? fieldsInAppPurchaseAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseImage>? fieldsInAppPurchaseImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseOfferCode>? fieldsInAppPurchaseOfferCodes = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsInAppPurchasesV2GetToManyRelatedIncludeItem>? include = default,
            int? limitInAppPurchaseLocalizations = default,
            int? limitImages = default,
            int? limitOfferCodes = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}