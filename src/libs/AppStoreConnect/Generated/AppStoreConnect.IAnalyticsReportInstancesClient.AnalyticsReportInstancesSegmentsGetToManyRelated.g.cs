#nullable enable

namespace AppStoreConnect
{
    public partial interface IAnalyticsReportInstancesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAnalyticsReportSegments"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AnalyticsReportSegmentsResponse> AnalyticsReportInstancesSegmentsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment>? fieldsAnalyticsReportSegments = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAnalyticsReportSegments"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AnalyticsReportSegmentsResponse>> AnalyticsReportInstancesSegmentsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportInstancesSegmentsGetToManyRelatedFieldsAnalyticsReportSegment>? fieldsAnalyticsReportSegments = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}