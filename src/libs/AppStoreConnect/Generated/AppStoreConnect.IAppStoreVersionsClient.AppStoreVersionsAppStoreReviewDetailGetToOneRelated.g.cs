#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppStoreReviewDetails"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppStoreReviewAttachments"></param>
        /// <param name="include"></param>
        /// <param name="limitAppStoreReviewAttachments"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreReviewDetailResponse> AppStoreVersionsAppStoreReviewDetailGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment>? fieldsAppStoreReviewAttachments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem>? include = default,
            int? limitAppStoreReviewAttachments = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppStoreReviewDetails"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppStoreReviewAttachments"></param>
        /// <param name="include"></param>
        /// <param name="limitAppStoreReviewAttachments"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreReviewDetailResponse>> AppStoreVersionsAppStoreReviewDetailGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedFieldsAppStoreReviewAttachment>? fieldsAppStoreReviewAttachments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreVersionsAppStoreReviewDetailGetToOneRelatedIncludeItem>? include = default,
            int? limitAppStoreReviewAttachments = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}