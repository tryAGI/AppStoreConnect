#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppAssetLibrariesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterCategory"></param>
        /// <param name="filterState"></param>
        /// <param name="filterReferenceName"></param>
        /// <param name="filterSpecId"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsAppAssetLibraryVideos"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPlacements"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppAssetLibraryVideosResponse> AppAssetLibrariesVideosGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem>? filterCategory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<string>? filterReferenceName = default,
            global::System.Collections.Generic.IList<string>? filterSpecId = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo>? fieldsAppAssetLibraryVideos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedIncludeItem>? include = default,
            int? limitPlacements = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterCategory"></param>
        /// <param name="filterState"></param>
        /// <param name="filterReferenceName"></param>
        /// <param name="filterSpecId"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsAppAssetLibraryVideos"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPlacements"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppAssetLibraryVideosResponse>> AppAssetLibrariesVideosGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterCategoryItem>? filterCategory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<string>? filterReferenceName = default,
            global::System.Collections.Generic.IList<string>? filterSpecId = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryVideo>? fieldsAppAssetLibraryVideos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesVideosGetToManyRelatedIncludeItem>? include = default,
            int? limitPlacements = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}