#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppAssetLibraryRefDataClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlacementTypes"></param>
        /// <param name="filterPlacementProfileGroups"></param>
        /// <param name="filterFeatures"></param>
        /// <param name="filterSpecs"></param>
        /// <param name="fieldsAppAssetLibraryRefData"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppAssetLibraryRefDataResponse> AppAssetLibraryRefDataGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterPlacementTypes = default,
            global::System.Collections.Generic.IList<string>? filterPlacementProfileGroups = default,
            global::System.Collections.Generic.IList<string>? filterFeatures = default,
            global::System.Collections.Generic.IList<string>? filterSpecs = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem>? fieldsAppAssetLibraryRefData = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlacementTypes"></param>
        /// <param name="filterPlacementProfileGroups"></param>
        /// <param name="filterFeatures"></param>
        /// <param name="filterSpecs"></param>
        /// <param name="fieldsAppAssetLibraryRefData"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppAssetLibraryRefDataResponse>> AppAssetLibraryRefDataGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterPlacementTypes = default,
            global::System.Collections.Generic.IList<string>? filterPlacementProfileGroups = default,
            global::System.Collections.Generic.IList<string>? filterFeatures = default,
            global::System.Collections.Generic.IList<string>? filterSpecs = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem>? fieldsAppAssetLibraryRefData = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps AppAssetLibraryRefDataGetCollectionAsync as an IAsyncEnumerable&lt;global::AppStoreConnect.AppAssetLibraryRefDatum&gt; that follows the response's next-page URL.
        /// </summary>
        /// <param name="filterPlacementTypes"></param>
        /// <param name="filterPlacementProfileGroups"></param>
        /// <param name="filterFeatures"></param>
        /// <param name="filterSpecs"></param>
        /// <param name="fieldsAppAssetLibraryRefData"></param>
        /// <param name="requestOptions">Options forwarded to every page request.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::AppStoreConnect.AppAssetLibraryRefDatum> AppAssetLibraryRefDataGetCollectionAutoPagingAsync(
              global::System.Collections.Generic.IList<string>? filterPlacementTypes = default,
            global::System.Collections.Generic.IList<string>? filterPlacementProfileGroups = default,
            global::System.Collections.Generic.IList<string>? filterFeatures = default,
            global::System.Collections.Generic.IList<string>? filterSpecs = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryRefDataGetCollectionFieldsAppAssetLibraryRefDataItem>? fieldsAppAssetLibraryRefData = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}