#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreReviewDetailsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppStoreReviewAttachments"></param>
        /// <param name="fieldsAppStoreReviewDetails"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreReviewAttachmentsResponse> AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedFieldsAppStoreReviewAttachment>? fieldsAppStoreReviewAttachments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppStoreReviewAttachments"></param>
        /// <param name="fieldsAppStoreReviewDetails"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreReviewAttachmentsResponse>> AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedFieldsAppStoreReviewAttachment>? fieldsAppStoreReviewAttachments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsAppStoreReviewAttachmentsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}