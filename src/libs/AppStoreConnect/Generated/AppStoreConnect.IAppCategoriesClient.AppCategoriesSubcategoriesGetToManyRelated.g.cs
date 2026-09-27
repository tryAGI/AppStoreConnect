#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppCategoriesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppCategoriesWithoutIncludesResponse> AppCategoriesSubcategoriesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie>? fieldsAppCategories = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppCategoriesWithoutIncludesResponse>> AppCategoriesSubcategoriesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie>? fieldsAppCategories = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps AppCategoriesSubcategoriesGetToManyRelatedAsync as an IAsyncEnumerable&lt;global::AppStoreConnect.AppCategory&gt; that follows the response's next-page URL.
        /// </summary>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Options forwarded to every page request.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::AppStoreConnect.AppCategory> AppCategoriesSubcategoriesGetToManyRelatedAutoPagingAsync(
            string id,             global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesSubcategoriesGetToManyRelatedFieldsAppCategorie>? fieldsAppCategories = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}