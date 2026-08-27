#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaAppReviewSubmissionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaAppReviewSubmissions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaAppReviewSubmissionResponse> BetaAppReviewSubmissionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaAppReviewSubmissions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaAppReviewSubmissionResponse>> BetaAppReviewSubmissionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetInstanceFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}