#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppPriceSchedulesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppPriceSchedules"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsAppPrices"></param>
        /// <param name="include"></param>
        /// <param name="limitAutomaticPrices"></param>
        /// <param name="limitManualPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppPriceScheduleResponse> AppPriceSchedulesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule>? fieldsAppPriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice>? fieldsAppPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem>? include = default,
            int? limitAutomaticPrices = default,
            int? limitManualPrices = default,
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
        /// <param name="limitAutomaticPrices"></param>
        /// <param name="limitManualPrices"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppPriceScheduleResponse>> AppPriceSchedulesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPriceSchedule>? fieldsAppPriceSchedules = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceFieldsAppPrice>? fieldsAppPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPriceSchedulesGetInstanceIncludeItem>? include = default,
            int? limitAutomaticPrices = default,
            int? limitManualPrices = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}