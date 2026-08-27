#nullable enable

namespace AppStoreConnect
{
    public partial interface IFinanceReportsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterVendorNumber"></param>
        /// <param name="filterReportType"></param>
        /// <param name="filterRegionCode"></param>
        /// <param name="filterReportDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> FinanceReportsGetCollectionAsync(
            global::System.Collections.Generic.IList<string> filterVendorNumber,
            global::System.Collections.Generic.IList<global::AppStoreConnect.FinanceReportsGetCollectionFilterReportTypeItem> filterReportType,
            global::System.Collections.Generic.IList<string> filterRegionCode,
            global::System.Collections.Generic.IList<string> filterReportDate,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterVendorNumber"></param>
        /// <param name="filterReportType"></param>
        /// <param name="filterRegionCode"></param>
        /// <param name="filterReportDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> FinanceReportsGetCollectionAsStreamAsync(
            global::System.Collections.Generic.IList<string> filterVendorNumber,
            global::System.Collections.Generic.IList<global::AppStoreConnect.FinanceReportsGetCollectionFilterReportTypeItem> filterReportType,
            global::System.Collections.Generic.IList<string> filterRegionCode,
            global::System.Collections.Generic.IList<string> filterReportDate,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterVendorNumber"></param>
        /// <param name="filterReportType"></param>
        /// <param name="filterRegionCode"></param>
        /// <param name="filterReportDate"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<byte[]>> FinanceReportsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string> filterVendorNumber,
            global::System.Collections.Generic.IList<global::AppStoreConnect.FinanceReportsGetCollectionFilterReportTypeItem> filterReportType,
            global::System.Collections.Generic.IList<string> filterRegionCode,
            global::System.Collections.Generic.IList<string> filterReportDate,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}