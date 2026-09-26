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
        /// <param name="filterGameCenterMatchmakingQueue"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponse> GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsAsync(
            global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity granularity,
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem>? groupBy = default,
            string? filterGameCenterMatchmakingQueue = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem>? sort = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="granularity"></param>
        /// <param name="groupBy"></param>
        /// <param name="filterGameCenterMatchmakingQueue"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponse>> GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsAsResponseAsync(
            global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity granularity,
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem>? groupBy = default,
            string? filterGameCenterMatchmakingQueue = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem>? sort = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsAsync as an IAsyncEnumerable&lt;global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItem&gt; that follows the response's next-page URL.
        /// </summary>
        /// <param name="granularity"></param>
        /// <param name="groupBy"></param>
        /// <param name="filterGameCenterMatchmakingQueue"></param>
        /// <param name="sort"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Options forwarded to every page request.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::AppStoreConnect.GameCenterMatchmakingRuleErrorsV1MetricResponseDataItem> GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsAutoPagingAsync(
            global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGranularity granularity,
            string id,             global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsGroupByItem>? groupBy = default,
            string? filterGameCenterMatchmakingQueue = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterMatchmakingRulesMatchmakingRuleErrorsGetMetricsSortItem>? sort = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}