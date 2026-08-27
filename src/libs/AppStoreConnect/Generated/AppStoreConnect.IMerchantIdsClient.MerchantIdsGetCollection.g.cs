#nullable enable

namespace AppStoreConnect
{
    public partial interface IMerchantIdsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterIdentifier"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsMerchantIds"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.MerchantIdsResponse> MerchantIdsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<string>? filterIdentifier = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionFieldsMerchantId>? fieldsMerchantIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionFieldsCertificate>? fieldsCertificates = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionIncludeItem>? include = default,
            int? limitCertificates = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterIdentifier"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsMerchantIds"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.MerchantIdsResponse>> MerchantIdsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<string>? filterIdentifier = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionFieldsMerchantId>? fieldsMerchantIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionFieldsCertificate>? fieldsCertificates = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetCollectionIncludeItem>? include = default,
            int? limitCertificates = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}