#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreReviewAttachmentsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppStoreReviewAttachments"></param>
        /// <param name="fieldsAppStoreReviewDetails"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreReviewAttachmentResponse> AppStoreReviewAttachmentsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment>? fieldsAppStoreReviewAttachments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewAttachmentsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppStoreReviewAttachments"></param>
        /// <param name="fieldsAppStoreReviewDetails"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreReviewAttachmentResponse>> AppStoreReviewAttachmentsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewAttachment>? fieldsAppStoreReviewAttachments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewAttachmentsGetInstanceFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewAttachmentsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}