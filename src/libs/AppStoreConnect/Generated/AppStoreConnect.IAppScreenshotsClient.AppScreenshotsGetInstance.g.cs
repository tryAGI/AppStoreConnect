#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppScreenshotsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppScreenshots"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppScreenshotResponse> AppScreenshotsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshot>? fieldsAppScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppScreenshots"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppScreenshotResponse>> AppScreenshotsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshot>? fieldsAppScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotsGetInstanceFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}