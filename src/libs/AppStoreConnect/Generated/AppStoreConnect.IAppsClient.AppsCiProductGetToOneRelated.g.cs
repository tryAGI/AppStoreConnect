#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="include"></param>
        /// <param name="limitPrimaryRepositories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiProductResponse> AppsCiProductGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedIncludeItem>? include = default,
            int? limitPrimaryRepositories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBundleIds"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="include"></param>
        /// <param name="limitPrimaryRepositories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiProductResponse>> AppsCiProductGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsBundleId>? fieldsBundleIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCiProductGetToOneRelatedIncludeItem>? include = default,
            int? limitPrimaryRepositories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}