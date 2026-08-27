#nullable enable

namespace AppStoreConnect
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsCertificates"></param>
        /// <param name="fieldsPassTypeIds"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CertificateResponse> CertificatesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetInstanceFieldsCertificate>? fieldsCertificates = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetInstanceFieldsPassTypeId>? fieldsPassTypeIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsCertificates"></param>
        /// <param name="fieldsPassTypeIds"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CertificateResponse>> CertificatesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetInstanceFieldsCertificate>? fieldsCertificates = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetInstanceFieldsPassTypeId>? fieldsPassTypeIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}