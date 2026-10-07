#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppAssetLibraryPlacementOrderingRequestsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="include"></param>
        /// <param name="limitOrderedPlacements"></param>
        /// <param name="fieldsAppAssetLibraryPlacementOrderingRequests"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestResponse> AppAssetLibraryPlacementOrderingRequestsCreateInstanceAsync(

            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequest request,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem>? include = default,
            int? limitOrderedPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest>? fieldsAppAssetLibraryPlacementOrderingRequests = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="include"></param>
        /// <param name="limitOrderedPlacements"></param>
        /// <param name="fieldsAppAssetLibraryPlacementOrderingRequests"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestResponse>> AppAssetLibraryPlacementOrderingRequestsCreateInstanceAsResponseAsync(

            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequest request,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem>? include = default,
            int? limitOrderedPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest>? fieldsAppAssetLibraryPlacementOrderingRequests = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppAssetLibraryPlacements"></param>
        /// <param name="include"></param>
        /// <param name="limitOrderedPlacements"></param>
        /// <param name="fieldsAppAssetLibraryPlacementOrderingRequests"></param>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestResponse> AppAssetLibraryPlacementOrderingRequestsCreateInstanceAsync(
            global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestCreateRequestData data,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacement>? fieldsAppAssetLibraryPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceIncludeItem>? include = default,
            int? limitOrderedPlacements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppAssetLibraryPlacementOrderingRequestsCreateInstanceFieldsAppAssetLibraryPlacementOrderingRequest>? fieldsAppAssetLibraryPlacementOrderingRequests = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}