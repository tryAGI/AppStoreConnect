#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterMatchmakingRulesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="granularity"></param>
        /// <param name="groupBy"></param>
        /// <param name="filterResult"></param>
        /// <param name="filterGameCenterMatchmakingQueue"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponse> GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsAsync(
            global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity granularity,
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem>? groupBy = default,
            string? filterResult = default,
            string? filterGameCenterMatchmakingQueue = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem>? sort = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="granularity"></param>
        /// <param name="groupBy"></param>
        /// <param name="filterResult"></param>
        /// <param name="filterGameCenterMatchmakingQueue"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterMatchmakingBooleanRuleResultsV1MetricResponse>> GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsAsResponseAsync(
            global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGranularity granularity,
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsGroupByItem>? groupBy = default,
            string? filterResult = default,
            string? filterGameCenterMatchmakingQueue = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingBooleanRuleResultsGetMetricsSortItem>? sort = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}