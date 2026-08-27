#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaAppReviewSubmissionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterBetaReviewState"></param>
        /// <param name="filterBuild"></param>
        /// <param name="fieldsBetaAppReviewSubmissions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaAppReviewSubmissionsResponse> BetaAppReviewSubmissionsGetCollectionAsync(
            global::System.Collections.Generic.IList<string> filterBuild,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem>? filterBetaReviewState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetCollectionFieldsBuild>? fieldsBuilds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterBetaReviewState"></param>
        /// <param name="filterBuild"></param>
        /// <param name="fieldsBetaAppReviewSubmissions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaAppReviewSubmissionsResponse>> BetaAppReviewSubmissionsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string> filterBuild,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetCollectionFilterBetaReviewStateItem>? filterBetaReviewState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetCollectionFieldsBetaAppReviewSubmission>? fieldsBetaAppReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetCollectionFieldsBuild>? fieldsBuilds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewSubmissionsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}