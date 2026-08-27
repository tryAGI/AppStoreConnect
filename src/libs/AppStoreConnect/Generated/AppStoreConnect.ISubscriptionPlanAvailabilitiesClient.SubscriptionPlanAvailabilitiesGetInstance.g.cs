#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionPlanAvailabilitiesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSubscriptionPlanAvailabilities"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="limitAvailableTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionPlanAvailabilityResponse> SubscriptionPlanAvailabilitiesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie>? fieldsSubscriptionPlanAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPlanAvailabilitiesGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPlanAvailabilitiesGetInstanceIncludeItem>? include = default,
            int? limitAvailableTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSubscriptionPlanAvailabilities"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="limitAvailableTerritories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionPlanAvailabilityResponse>> SubscriptionPlanAvailabilitiesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie>? fieldsSubscriptionPlanAvailabilities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPlanAvailabilitiesGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPlanAvailabilitiesGetInstanceIncludeItem>? include = default,
            int? limitAvailableTerritories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}