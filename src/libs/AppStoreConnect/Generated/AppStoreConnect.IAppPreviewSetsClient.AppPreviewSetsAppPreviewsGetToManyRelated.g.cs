#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppPreviewSetsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppPreviews"></param>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppPreviewsResponse> AppPreviewSetsAppPreviewsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview>? fieldsAppPreviews = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppPreviews"></param>
        /// <param name="fieldsAppPreviewSets"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppPreviewsResponse>> AppPreviewSetsAppPreviewsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreview>? fieldsAppPreviews = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedFieldsAppPreviewSet>? fieldsAppPreviewSets = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppPreviewSetsAppPreviewsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}