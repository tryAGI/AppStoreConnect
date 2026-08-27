#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppCustomProductPagesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterState"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="fieldsAppCustomProductPages"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppCustomProductPageLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppCustomProductPageVersionsResponse> AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage>? fieldsAppCustomProductPages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppCustomProductPageLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterState"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="fieldsAppCustomProductPages"></param>
        /// <param name="fieldsAppCustomProductPageLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppCustomProductPageLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppCustomProductPageVersionsResponse>> AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPage>? fieldsAppCustomProductPages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedFieldsAppCustomProductPageLocalization>? fieldsAppCustomProductPageLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCustomProductPagesAppCustomProductPageVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitAppCustomProductPageLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}