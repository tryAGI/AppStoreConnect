#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaFeedbackScreenshotSubmissionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsBetaFeedbackScreenshotSubmissions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponse> BetaFeedbackScreenshotSubmissionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission>? fieldsBetaFeedbackScreenshotSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsBetaFeedbackScreenshotSubmissions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionResponse>> BetaFeedbackScreenshotSubmissionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaFeedbackScreenshotSubmission>? fieldsBetaFeedbackScreenshotSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackScreenshotSubmissionsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}