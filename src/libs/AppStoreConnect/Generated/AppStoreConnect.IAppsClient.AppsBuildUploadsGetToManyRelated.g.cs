#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterCfBundleShortVersionString"></param>
        /// <param name="filterCfBundleVersion"></param>
        /// <param name="filterPlatform"></param>
        /// <param name="filterState"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBuildUploads"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBuildUploadFiles"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BuildUploadsResponse> AppsBuildUploadsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterCfBundleShortVersionString = default,
            global::System.Collections.Generic.IList<string>? filterCfBundleVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedFieldsBuildUpload>? fieldsBuildUploads = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile>? fieldsBuildUploadFiles = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterCfBundleShortVersionString"></param>
        /// <param name="filterCfBundleVersion"></param>
        /// <param name="filterPlatform"></param>
        /// <param name="filterState"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBuildUploads"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBuildUploadFiles"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BuildUploadsResponse>> AppsBuildUploadsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterCfBundleShortVersionString = default,
            global::System.Collections.Generic.IList<string>? filterCfBundleVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedFieldsBuildUpload>? fieldsBuildUploads = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedFieldsBuildUploadFile>? fieldsBuildUploadFiles = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsBuildUploadsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}