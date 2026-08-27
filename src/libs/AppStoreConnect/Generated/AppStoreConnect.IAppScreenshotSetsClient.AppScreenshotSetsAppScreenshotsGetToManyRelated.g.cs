#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppScreenshotSetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppScreenshots"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppScreenshotsResponse> AppScreenshotSetsAppScreenshotsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot>? fieldsAppScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppScreenshots"></param>
        /// <param name="fieldsAppScreenshotSets"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppScreenshotsResponse>> AppScreenshotSetsAppScreenshotsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshot>? fieldsAppScreenshots = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedFieldsAppScreenshotSet>? fieldsAppScreenshotSets = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppScreenshotSetsAppScreenshotsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}