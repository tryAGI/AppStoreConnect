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
        /// <param name="fieldsAppAssetLibraryImages"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPlacements"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppAssetLibraryImagesResponse> AppAssetLibrariesImagesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem>? filterCategory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<string>? filterReferenceName = default,
            global::System.Collections.Generic.IList<string>? filterSpecId = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage>? fieldsAppAssetLibraryImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedIncludeItem>? include = default,
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
        /// <param name="fieldsAppAssetLibraryImages"></param>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPlacements"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppAssetLibraryImagesResponse>> AppAssetLibrariesImagesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterCategoryItem>? filterCategory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<string>? filterReferenceName = default,
            global::System.Collections.Generic.IList<string>? filterSpecId = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryImage>? fieldsAppAssetLibraryImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibrariesImagesGetToManyRelatedIncludeItem>? include = default,
            int? limitPlacements = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}