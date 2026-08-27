#nullable enable

namespace AppStoreConnect
{
    public partial interface ISalesReportsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterVendorNumber"></param>
        /// <param name="filterReportType"></param>
        /// <param name="filterReportSubType"></param>
        /// <param name="filterFrequency"></param>
        /// <param name="filterReportDate"></param>
        /// <param name="filterVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> SalesReportsGetCollectionAsync(
            global::System.Collections.Generic.IList<string> filterVendorNumber,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SalesReportsGetCollectionFilterReportTypeItem> filterReportType,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SalesReportsGetCollectionFilterReportSubTypeItem> filterReportSubType,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SalesReportsGetCollectionFilterFrequencyItem> filterFrequency,
            global::System.Collections.Generic.IList<string>? filterReportDate = default,
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterVendorNumber"></param>
        /// <param name="filterReportType"></param>
        /// <param name="filterReportSubType"></param>
        /// <param name="filterFrequency"></param>
        /// <param name="filterReportDate"></param>
        /// <param name="filterVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.IO.Stream> SalesReportsGetCollectionAsStreamAsync(
            global::System.Collections.Generic.IList<string> filterVendorNumber,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SalesReportsGetCollectionFilterReportTypeItem> filterReportType,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SalesReportsGetCollectionFilterReportSubTypeItem> filterReportSubType,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SalesReportsGetCollectionFilterFrequencyItem> filterFrequency,
            global::System.Collections.Generic.IList<string>? filterReportDate = default,
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterVendorNumber"></param>
        /// <param name="filterReportType"></param>
        /// <param name="filterReportSubType"></param>
        /// <param name="filterFrequency"></param>
        /// <param name="filterReportDate"></param>
        /// <param name="filterVersion"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<byte[]>> SalesReportsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string> filterVendorNumber,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SalesReportsGetCollectionFilterReportTypeItem> filterReportType,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SalesReportsGetCollectionFilterReportSubTypeItem> filterReportSubType,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SalesReportsGetCollectionFilterFrequencyItem> filterFrequency,
            global::System.Collections.Generic.IList<string>? filterReportDate = default,
            global::System.Collections.Generic.IList<string>? filterVersion = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}