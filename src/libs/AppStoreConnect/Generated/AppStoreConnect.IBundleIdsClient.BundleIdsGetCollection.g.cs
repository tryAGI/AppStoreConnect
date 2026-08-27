#nullable enable

namespace AppStoreConnect
{
    public partial interface IBundleIdsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterPlatform"></param>
        /// <param name="filterIdentifier"></param>
        /// <param name="filterSeedId"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsProfiles"></param>
        /// <param name="fieldsBundleIdCapabilities"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBundleIdCapabilities"></param>
        /// <param name="limitProfiles"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BundleIdsResponse> BundleIdsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterIdentifier = default,
            global::System.Collections.Generic.IList<string>? filterSeedId = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionFieldsProfile>? fieldsProfiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionFieldsBundleIdCapabilitie>? fieldsBundleIdCapabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionIncludeItem>? include = default,
            int? limitBundleIdCapabilities = default,
            int? limitProfiles = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterPlatform"></param>
        /// <param name="filterIdentifier"></param>
        /// <param name="filterSeedId"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsProfiles"></param>
        /// <param name="fieldsBundleIdCapabilities"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBundleIdCapabilities"></param>
        /// <param name="limitProfiles"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BundleIdsResponse>> BundleIdsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterIdentifier = default,
            global::System.Collections.Generic.IList<string>? filterSeedId = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionFieldsProfile>? fieldsProfiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionFieldsBundleIdCapabilitie>? fieldsBundleIdCapabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetCollectionIncludeItem>? include = default,
            int? limitBundleIdCapabilities = default,
            int? limitProfiles = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}