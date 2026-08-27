#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppCustomProductPageLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="include"></param>
        /// <param name="limitAppPreviewSets"></param>
        /// <param name="limitAppScreenshotSets"></param>
        /// <param name="limitSearchKeywords"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppCustomProductPageLocalizationResponse> AppCustomProductPageLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceIncludeItem>? include = default,
            int? limitAppPreviewSets = default,
            int? limitAppScreenshotSets = default,
            int? limitSearchKeywords = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="include"></param>
        /// <param name="limitAppPreviewSets"></param>
        /// <param name="limitAppScreenshotSets"></param>
        /// <param name="limitSearchKeywords"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppCustomProductPageLocalizationResponse>> AppCustomProductPageLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPageLocalizationsGetInstanceIncludeItem>? include = default,
            int? limitAppPreviewSets = default,
            int? limitAppScreenshotSets = default,
            int? limitSearchKeywords = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}