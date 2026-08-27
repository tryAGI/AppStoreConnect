#nullable enable

namespace AppStoreConnect
{
    public partial interface IBundleIdsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsProfiles"></param>
        /// <param name="fieldsBundleIdCapabilities"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="include"></param>
        /// <param name="limitBundleIdCapabilities"></param>
        /// <param name="limitProfiles"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BundleIdResponse> BundleIdsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsProfile>? fieldsProfiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleIdCapabilitie>? fieldsBundleIdCapabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceIncludeItem>? include = default,
            int? limitBundleIdCapabilities = default,
            int? limitProfiles = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsProfiles"></param>
        /// <param name="fieldsBundleIdCapabilities"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="include"></param>
        /// <param name="limitBundleIdCapabilities"></param>
        /// <param name="limitProfiles"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BundleIdResponse>> BundleIdsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsProfile>? fieldsProfiles = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsBundleIdCapabilitie>? fieldsBundleIdCapabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BundleIdsGetInstanceIncludeItem>? include = default,
            int? limitBundleIdCapabilities = default,
            int? limitProfiles = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}