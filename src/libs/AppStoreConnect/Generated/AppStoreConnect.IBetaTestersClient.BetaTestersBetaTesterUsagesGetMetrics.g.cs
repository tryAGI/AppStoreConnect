#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaTestersClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="period"></param>
        /// <param name="filterApps"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaTesterUsagesV1MetricResponse> BetaTestersBetaTesterUsagesGetMetricsAsync(
            string filterApps,
            string id,
            global::AppStoreConnect.BetaTestersBetaTesterUsagesGetMetricsPeriod? period = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="period"></param>
        /// <param name="filterApps"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaTesterUsagesV1MetricResponse>> BetaTestersBetaTesterUsagesGetMetricsAsResponseAsync(
            string filterApps,
            string id,
            global::AppStoreConnect.BetaTestersBetaTesterUsagesGetMetricsPeriod? period = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}