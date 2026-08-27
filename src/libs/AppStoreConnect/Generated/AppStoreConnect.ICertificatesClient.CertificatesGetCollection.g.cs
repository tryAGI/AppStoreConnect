#nullable enable

namespace AppStoreConnect
{
    public partial interface ICertificatesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterDisplayName"></param>
        /// <param name="filterCertificateType"></param>
        /// <param name="filterSerialNumber"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="fieldsPassTypeIds"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CertificatesResponse> CertificatesGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterDisplayName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem>? filterCertificateType = default,
            global::System.Collections.Generic.IList<string>? filterSerialNumber = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate>? fieldsCertificates = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId>? fieldsPassTypeIds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterDisplayName"></param>
        /// <param name="filterCertificateType"></param>
        /// <param name="filterSerialNumber"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="fieldsPassTypeIds"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CertificatesResponse>> CertificatesGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterDisplayName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFilterCertificateTypeItem>? filterCertificateType = default,
            global::System.Collections.Generic.IList<string>? filterSerialNumber = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFieldsCertificate>? fieldsCertificates = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionFieldsPassTypeId>? fieldsPassTypeIds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CertificatesGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}