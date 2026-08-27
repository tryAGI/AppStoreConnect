#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppCategoriesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppCategoryWithoutIncludesResponse> AppCategoriesParentGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesParentGetToOneRelatedFieldsAppCategorie>? fieldsAppCategories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppCategoryWithoutIncludesResponse>> AppCategoriesParentGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppCategoriesParentGetToOneRelatedFieldsAppCategorie>? fieldsAppCategories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}