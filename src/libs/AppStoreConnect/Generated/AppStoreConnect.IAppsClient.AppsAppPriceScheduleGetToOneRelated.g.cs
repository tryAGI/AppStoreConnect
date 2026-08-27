#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppPriceSchedules"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsAppPrices"></param>
        /// <param name="include"></param>
        /// <param name="limitManualPrices"></param>
        /// <param name="limitAutomaticPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppPriceScheduleResponse> AppsAppPriceScheduleGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule>? fieldsAppPriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice>? fieldsAppPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedIncludeItem>? include = default,
            int? limitManualPrices = default,
            int? limitAutomaticPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppPriceSchedules"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsAppPrices"></param>
        /// <param name="include"></param>
        /// <param name="limitManualPrices"></param>
        /// <param name="limitAutomaticPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppPriceScheduleResponse>> AppsAppPriceScheduleGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPriceSchedule>? fieldsAppPriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedFieldsAppPrice>? fieldsAppPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppPriceScheduleGetToOneRelatedIncludeItem>? include = default,
            int? limitManualPrices = default,
            int? limitAutomaticPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}