#nullable enable

namespace AppStoreConnect
{
    public partial interface IPassTypeIdsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterIdentifier"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsPassTypeIds"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.PassTypeIdsResponse> PassTypeIdsGetCollectionAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<string>? filterIdentifier = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetCollectionFieldsPassTypeId>? fieldsPassTypeIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetCollectionFieldsCertificate>? fieldsCertificates = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetCollectionIncludeItem>? include = default,
            int? limitCertificates = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="filterIdentifier"></param>
        /// <param name="filterId"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsPassTypeIds"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.PassTypeIdsResponse>> PassTypeIdsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string>? filterName = default,
            global::System.Collections.Generic.IList<string>? filterIdentifier = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetCollectionSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetCollectionFieldsPassTypeId>? fieldsPassTypeIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetCollectionFieldsCertificate>? fieldsCertificates = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PassTypeIdsGetCollectionIncludeItem>? include = default,
            int? limitCertificates = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}