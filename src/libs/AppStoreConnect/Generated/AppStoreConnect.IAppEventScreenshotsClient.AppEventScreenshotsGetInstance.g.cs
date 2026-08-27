#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppEventScreenshotsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppEventScreenshots"></param>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppEventScreenshotResponse> AppEventScreenshotsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventScreenshot>? fieldsAppEventScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventScreenshotsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppEventScreenshots"></param>
        /// <param name="fieldsAppEventLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppEventScreenshotResponse>> AppEventScreenshotsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventScreenshot>? fieldsAppEventScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventScreenshotsGetInstanceFieldsAppEventLocalization>? fieldsAppEventLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEventScreenshotsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}