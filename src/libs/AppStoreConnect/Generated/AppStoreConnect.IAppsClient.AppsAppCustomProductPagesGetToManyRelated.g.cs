#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterVisible"></param>
        /// <param name="fieldsAppCustomProductPages"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppCustomProductPageVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppCustomProductPagesResponse> AppsAppCustomProductPagesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterVisible = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage>? fieldsAppCustomProductPages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppCustomProductPagesGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppCustomProductPagesGetToManyRelatedIncludeItem>? include = default,
            int? limitAppCustomProductPageVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterVisible"></param>
        /// <param name="fieldsAppCustomProductPages"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppCustomProductPageVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppCustomProductPagesResponse>> AppsAppCustomProductPagesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterVisible = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPage>? fieldsAppCustomProductPages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppCustomProductPagesGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppCustomProductPagesGetToManyRelatedFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppCustomProductPagesGetToManyRelatedIncludeItem>? include = default,
            int? limitAppCustomProductPageVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}