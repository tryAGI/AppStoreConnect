#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchasesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchasePriceSchedules"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsInAppPurchasePrices"></param>
        /// <param name="include"></param>
        /// <param name="limitManualPrices"></param>
        /// <param name="limitAutomaticPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchasePriceScheduleResponse> InAppPurchasesV2IapPriceScheduleGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule>? fieldsInAppPurchasePriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice>? fieldsInAppPurchasePrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem>? include = default,
            int? limitManualPrices = default,
            int? limitAutomaticPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchasePriceSchedules"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsInAppPurchasePrices"></param>
        /// <param name="include"></param>
        /// <param name="limitManualPrices"></param>
        /// <param name="limitAutomaticPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchasePriceScheduleResponse>> InAppPurchasesV2IapPriceScheduleGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePriceSchedule>? fieldsInAppPurchasePriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2IapPriceScheduleGetToOneRelatedFieldsInAppPurchasePrice>? fieldsInAppPurchasePrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasesV2IapPriceScheduleGetToOneRelatedIncludeItem>? include = default,
            int? limitManualPrices = default,
            int? limitAutomaticPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}