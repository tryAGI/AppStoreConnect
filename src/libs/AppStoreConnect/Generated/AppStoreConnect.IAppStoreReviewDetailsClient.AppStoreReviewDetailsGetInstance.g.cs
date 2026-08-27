#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppStoreReviewDetailsClient
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppStoreReviewDetailResponse> AppStoreReviewDetailsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment>? fieldsAppStoreReviewAttachments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsGetInstanceIncludeItem>? include = default,
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppStoreReviewDetailResponse>> AppStoreReviewDetailsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewDetail>? fieldsAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsGetInstanceFieldsAppStoreReviewAttachment>? fieldsAppStoreReviewAttachments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppStoreReviewDetailsGetInstanceIncludeItem>? include = default,
            int? limitAppStoreReviewAttachments = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}