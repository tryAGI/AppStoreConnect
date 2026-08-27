#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseAvailabilitiesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseAvailabilities"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="limitAvailableTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseAvailabilityResponse> InAppPurchaseAvailabilitiesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie>? fieldsInAppPurchaseAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseAvailabilitiesGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseAvailabilitiesGetInstanceIncludeItem>? include = default,
            int? limitAvailableTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseAvailabilities"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="limitAvailableTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseAvailabilityResponse>> InAppPurchaseAvailabilitiesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseAvailabilitiesGetInstanceFieldsInAppPurchaseAvailabilitie>? fieldsInAppPurchaseAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseAvailabilitiesGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseAvailabilitiesGetInstanceIncludeItem>? include = default,
            int? limitAvailableTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}