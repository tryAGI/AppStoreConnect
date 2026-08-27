#nullable enable

namespace AppStoreConnect
{
    public partial interface IAnalyticsReportRequestsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterCategory"></param>
        /// <param name="fieldsAnalyticsReports"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AnalyticsReportsResponse> AnalyticsReportRequestsReportsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem>? filterCategory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport>? fieldsAnalyticsReports = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterCategory"></param>
        /// <param name="fieldsAnalyticsReports"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AnalyticsReportsResponse>> AnalyticsReportRequestsReportsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFilterCategoryItem>? filterCategory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AnalyticsReportRequestsReportsGetToManyRelatedFieldsAnalyticsReport>? fieldsAnalyticsReports = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}