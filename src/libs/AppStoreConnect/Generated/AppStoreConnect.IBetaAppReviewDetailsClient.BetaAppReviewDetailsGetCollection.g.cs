#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaAppReviewDetailsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterApp"></param>
        /// <param name="fieldsBetaAppReviewDetails"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaAppReviewDetailsResponse> BetaAppReviewDetailsGetCollectionAsync(
            global::System.Collections.Generic.IList<string> filterApp,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterApp"></param>
        /// <param name="fieldsBetaAppReviewDetails"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaAppReviewDetailsResponse>> BetaAppReviewDetailsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string> filterApp,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetCollectionFieldsBetaAppReviewDetail>? fieldsBetaAppReviewDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetCollectionFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppReviewDetailsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}