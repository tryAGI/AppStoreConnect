#nullable enable

namespace AppStoreConnect
{
    public partial interface IPreReleaseVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterBuildsBuildAudienceType"></param>
        /// <param name="filterBuildsExpired"></param>
        /// <param name="filterBuildsProcessingState"></param>
        /// <param name="filterBuildsVersion"></param>
        /// <param name="filterPlatform"></param>
        /// <param name="filterVersion"></param>
        /// <param name="filterApp"></param>
        /// <param name="filterBuilds"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsPreReleaseVersions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.PreReleaseVersionsResponse> PreReleaseVersionsGetCollectionAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFilterBuildsBuildAudienceTypeItem>? filterBuildsBuildAudienceType = default,
            global::System.Collections.Generic.IList<string>? filterBuildsExpired = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem>? filterBuildsProcessingState = default,
            global::System.Collections.Generic.IList<string>? filterBuildsVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterBuildsBuildAudienceType"></param>
        /// <param name="filterBuildsExpired"></param>
        /// <param name="filterBuildsProcessingState"></param>
        /// <param name="filterBuildsVersion"></param>
        /// <param name="filterPlatform"></param>
        /// <param name="filterVersion"></param>
        /// <param name="filterApp"></param>
        /// <param name="filterBuilds"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsPreReleaseVersions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.PreReleaseVersionsResponse>> PreReleaseVersionsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFilterBuildsBuildAudienceTypeItem>? filterBuildsBuildAudienceType = default,
            global::System.Collections.Generic.IList<string>? filterBuildsExpired = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFilterBuildsProcessingStateItem>? filterBuildsProcessingState = default,
            global::System.Collections.Generic.IList<string>? filterBuildsVersion = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFieldsPreReleaseVersion>? fieldsPreReleaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PreReleaseVersionsGetCollectionIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}