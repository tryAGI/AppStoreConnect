#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaGroupsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="period"></param>
        /// <param name="groupBy"></param>
        /// <param name="filterBetaTesters"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponse> BetaGroupsBetaTesterUsagesGetMetricsAsync(
            string id,
            global::AppStoreConnect.BetaGroupsBetaTesterUsagesGetMetricsPeriod? period = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsBetaTesterUsagesGetMetricsGroupByItem>? groupBy = default,
            string? filterBetaTesters = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="period"></param>
        /// <param name="groupBy"></param>
        /// <param name="filterBetaTesters"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppsBetaTesterUsagesV1MetricResponse>> BetaGroupsBetaTesterUsagesGetMetricsAsResponseAsync(
            string id,
            global::AppStoreConnect.BetaGroupsBetaTesterUsagesGetMetricsPeriod? period = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaGroupsBetaTesterUsagesGetMetricsGroupByItem>? groupBy = default,
            string? filterBetaTesters = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}