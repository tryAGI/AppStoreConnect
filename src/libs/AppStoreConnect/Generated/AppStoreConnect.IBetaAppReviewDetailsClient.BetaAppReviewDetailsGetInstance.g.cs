#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaAppReviewDetailsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaAppReviewDetails"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaAppReviewDetailResponse> BetaAppReviewDetailsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaAppReviewDetails"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaAppReviewDetailResponse>> BetaAppReviewDetailsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetInstanceFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}