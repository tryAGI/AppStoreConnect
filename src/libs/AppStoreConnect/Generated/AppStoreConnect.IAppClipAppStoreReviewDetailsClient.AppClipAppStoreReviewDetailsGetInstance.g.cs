#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppClipAppStoreReviewDetailsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppClipAppStoreReviewDetails"></param>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppClipAppStoreReviewDetailResponse> AppClipAppStoreReviewDetailsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail>? fieldsAppClipAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppClipAppStoreReviewDetails"></param>
        /// <param name="fieldsAppClipDefaultExperiences"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppClipAppStoreReviewDetailResponse>> AppClipAppStoreReviewDetailsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipAppStoreReviewDetail>? fieldsAppClipAppStoreReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceFieldsAppClipDefaultExperience>? fieldsAppClipDefaultExperiences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppClipAppStoreReviewDetailsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}