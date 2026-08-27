#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreVersionLocalizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppStoreVersions"></param>
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreVersionLocalizationResponse> AppStoreVersionLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsGetInstanceFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsGetInstanceIncludeItem>? include = default,
            int? limitAppPreviewSets = default,
            int? limitAppScreenshotSets = default,
            int? limitSearchKeywords = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppStoreVersionLocalizations"></param>
        /// <param name="fieldsAppStoreVersions"></param>
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreVersionLocalizationResponse>> AppStoreVersionLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization>? fieldsAppStoreVersionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsGetInstanceFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsGetInstanceFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionLocalizationsGetInstanceIncludeItem>? include = default,
            int? limitAppPreviewSets = default,
            int? limitAppScreenshotSets = default,
            int? limitSearchKeywords = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}