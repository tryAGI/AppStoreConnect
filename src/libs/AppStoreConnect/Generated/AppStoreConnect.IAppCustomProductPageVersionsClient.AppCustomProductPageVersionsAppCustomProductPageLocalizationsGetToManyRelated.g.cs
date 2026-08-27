#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppCustomProductPageVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="fieldsAppKeywords"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppScreenshotSets"></param>
        /// <param name="limitAppPreviewSets"></param>
        /// <param name="limitSearchKeywords"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppCustomProductPageLocalizationsResponse> AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<string>? fieldsAppKeywords = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppScreenshotSets = default,
            int? limitAppPreviewSets = default,
            int? limitSearchKeywords = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="fieldsAppKeywords"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppScreenshotSets"></param>
        /// <param name="limitAppPreviewSets"></param>
        /// <param name="limitSearchKeywords"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppCustomProductPageLocalizationsResponse>> AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<string>? fieldsAppKeywords = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageVersionsAppCustomProductPageLocalizationsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppScreenshotSets = default,
            int? limitAppPreviewSets = default,
            int? limitSearchKeywords = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}