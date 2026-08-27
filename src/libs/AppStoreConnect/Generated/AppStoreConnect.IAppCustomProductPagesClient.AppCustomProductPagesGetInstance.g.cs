#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppCustomProductPagesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppCustomProductPages"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitAppCustomProductPageVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppCustomProductPageResponse> AppCustomProductPagesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPage>? fieldsAppCustomProductPages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceIncludeItem>? include = default,
            int? limitAppCustomProductPageVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppCustomProductPages"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitAppCustomProductPageVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppCustomProductPageResponse>> AppCustomProductPagesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPage>? fieldsAppCustomProductPages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesGetInstanceIncludeItem>? include = default,
            int? limitAppCustomProductPageVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}