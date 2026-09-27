#nullable enable

namespace AppStoreConnect
{
    public partial interface IAnalyticsReportsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterGranularity"></param>
        /// <param name="filterProcessingDate"></param>
        /// <param name="fieldsAnalyticsReportInstances"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AnalyticsReportInstancesResponse> AnalyticsReportsInstancesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem>? filterGranularity = default,
            global::System.Collections.Generic.IList<string>? filterProcessingDate = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance>? fieldsAnalyticsReportInstances = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterGranularity"></param>
        /// <param name="filterProcessingDate"></param>
        /// <param name="fieldsAnalyticsReportInstances"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AnalyticsReportInstancesResponse>> AnalyticsReportsInstancesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem>? filterGranularity = default,
            global::System.Collections.Generic.IList<string>? filterProcessingDate = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance>? fieldsAnalyticsReportInstances = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps AnalyticsReportsInstancesGetToManyRelatedAsync as an IAsyncEnumerable&lt;global::AppStoreConnect.AnalyticsReportInstance&gt; that follows the response's next-page URL.
        /// </summary>
        /// <param name="filterGranularity"></param>
        /// <param name="filterProcessingDate"></param>
        /// <param name="fieldsAnalyticsReportInstances"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Options forwarded to every page request.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::AppStoreConnect.AnalyticsReportInstance> AnalyticsReportsInstancesGetToManyRelatedAutoPagingAsync(
            string id,             global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportsInstancesGetToManyRelatedFilterGranularityItem>? filterGranularity = default,
            global::System.Collections.Generic.IList<string>? filterProcessingDate = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportsInstancesGetToManyRelatedFieldsAnalyticsReportInstance>? fieldsAnalyticsReportInstances = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}