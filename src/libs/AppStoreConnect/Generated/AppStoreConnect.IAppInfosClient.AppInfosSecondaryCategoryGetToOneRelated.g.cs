#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppInfosClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="include"></param>
        /// <param name="limitSubcategories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppCategoryResponse> AppInfosSecondaryCategoryGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie>? fieldsAppCategories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedIncludeItem>? include = default,
            int? limitSubcategories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="include"></param>
        /// <param name="limitSubcategories"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppCategoryResponse>> AppInfosSecondaryCategoryGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedFieldsAppCategorie>? fieldsAppCategories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosSecondaryCategoryGetToOneRelatedIncludeItem>? include = default,
            int? limitSubcategories = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}