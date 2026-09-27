#nullable enable

namespace AppStoreConnect
{
    public partial interface IBuildsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterDiagnosticType"></param>
        /// <param name="fieldsDiagnosticSignatures"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.DiagnosticSignaturesResponse> BuildsDiagnosticSignaturesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem>? filterDiagnosticType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature>? fieldsDiagnosticSignatures = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterDiagnosticType"></param>
        /// <param name="fieldsDiagnosticSignatures"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.DiagnosticSignaturesResponse>> BuildsDiagnosticSignaturesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem>? filterDiagnosticType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature>? fieldsDiagnosticSignatures = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps BuildsDiagnosticSignaturesGetToManyRelatedAsync as an IAsyncEnumerable&lt;global::AppStoreConnect.DiagnosticSignature&gt; that follows the response's next-page URL.
        /// </summary>
        /// <param name="filterDiagnosticType"></param>
        /// <param name="fieldsDiagnosticSignatures"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Options forwarded to every page request.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::AppStoreConnect.DiagnosticSignature> BuildsDiagnosticSignaturesGetToManyRelatedAutoPagingAsync(
            string id,             global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFilterDiagnosticTypeItem>? filterDiagnosticType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BuildsDiagnosticSignaturesGetToManyRelatedFieldsDiagnosticSignature>? fieldsDiagnosticSignatures = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}