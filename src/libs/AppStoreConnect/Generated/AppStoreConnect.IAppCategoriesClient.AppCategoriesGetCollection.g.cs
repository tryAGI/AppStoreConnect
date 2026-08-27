#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppCategoriesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatforms"></param>
        /// <param name="existsParent"></param>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitSubcategories"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppCategoriesResponse> AppCategoriesGetCollectionAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform>? filterPlatforms = default,
            bool? existsParent = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie>? fieldsAppCategories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem>? include = default,
            int? limitSubcategories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatforms"></param>
        /// <param name="existsParent"></param>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitSubcategories"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppCategoriesResponse>> AppCategoriesGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionFilterPlatform>? filterPlatforms = default,
            bool? existsParent = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionFieldsAppCategorie>? fieldsAppCategories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesGetCollectionIncludeItem>? include = default,
            int? limitSubcategories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}