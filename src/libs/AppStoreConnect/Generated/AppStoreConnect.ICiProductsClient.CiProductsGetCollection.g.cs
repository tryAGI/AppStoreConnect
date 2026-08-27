#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiProductsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterProductType"></param>
        /// <param name="filterApp"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPrimaryRepositories"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiProductsResponse> CiProductsGetCollectionAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem>? filterProductType = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie>? fieldsScmRepositories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionIncludeItem>? include = default,
            int? limitPrimaryRepositories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterProductType"></param>
        /// <param name="filterApp"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitPrimaryRepositories"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiProductsResponse>> CiProductsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFilterProductTypeItem>? filterProductType = default,
            global::System.Collections.Generic.IList<string>? filterApp = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionFieldsScmRepositorie>? fieldsScmRepositories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsGetCollectionIncludeItem>? include = default,
            int? limitPrimaryRepositories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}