#nullable enable

namespace AppStoreConnect
{
    public partial interface IBuildUploadsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsBuildUploads"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBuildUploadFiles"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BuildUploadResponse> BuildUploadsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildUploadsGetInstanceFieldsBuildUpload>? fieldsBuildUploads = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildUploadsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildUploadsGetInstanceFieldsBuildUploadFile>? fieldsBuildUploadFiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildUploadsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsBuildUploads"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBuildUploadFiles"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BuildUploadResponse>> BuildUploadsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildUploadsGetInstanceFieldsBuildUpload>? fieldsBuildUploads = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildUploadsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildUploadsGetInstanceFieldsBuildUploadFile>? fieldsBuildUploadFiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildUploadsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}