#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterAccessType"></param>
        /// <param name="fieldsAnalyticsReportRequests"></param>
        /// <param name="fieldsAnalyticsReports"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitReports"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AnalyticsReportRequestsResponse> AppsAnalyticsReportRequestsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem>? filterAccessType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest>? fieldsAnalyticsReportRequests = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport>? fieldsAnalyticsReports = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem>? include = default,
            int? limitReports = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterAccessType"></param>
        /// <param name="fieldsAnalyticsReportRequests"></param>
        /// <param name="fieldsAnalyticsReports"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitReports"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AnalyticsReportRequestsResponse>> AppsAnalyticsReportRequestsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFilterAccessTypeItem>? filterAccessType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReportRequest>? fieldsAnalyticsReportRequests = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedFieldsAnalyticsReport>? fieldsAnalyticsReports = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAnalyticsReportRequestsGetToManyRelatedIncludeItem>? include = default,
            int? limitReports = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}