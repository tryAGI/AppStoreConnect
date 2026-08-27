#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppClipDefaultExperiencesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationshipAsync(
            string id,

            global::AppStoreConnect.AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse> AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationshipAsResponseAsync(
            string id,

            global::AppStoreConnect.AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AppClipDefaultExperiencesReleaseWithAppStoreVersionUpdateToOneRelationshipAsync(
            string id,
            global::AppStoreConnect.AppClipDefaultExperienceReleaseWithAppStoreVersionLinkageRequestData data,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}