#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchasePriceSchedulesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchasePriceSchedules"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsInAppPurchasePrices"></param>
        /// <param name="include"></param>
        /// <param name="limitAutomaticPrices"></param>
        /// <param name="limitManualPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchasePriceScheduleResponse> InAppPurchasePriceSchedulesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule>? fieldsInAppPurchasePriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice>? fieldsInAppPurchasePrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesGetInstanceIncludeItem>? include = default,
            int? limitAutomaticPrices = default,
            int? limitManualPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchasePriceSchedules"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsInAppPurchasePrices"></param>
        /// <param name="include"></param>
        /// <param name="limitAutomaticPrices"></param>
        /// <param name="limitManualPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchasePriceScheduleResponse>> InAppPurchasePriceSchedulesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePriceSchedule>? fieldsInAppPurchasePriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesGetInstanceFieldsInAppPurchasePrice>? fieldsInAppPurchasePrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePriceSchedulesGetInstanceIncludeItem>? include = default,
            int? limitAutomaticPrices = default,
            int? limitManualPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}