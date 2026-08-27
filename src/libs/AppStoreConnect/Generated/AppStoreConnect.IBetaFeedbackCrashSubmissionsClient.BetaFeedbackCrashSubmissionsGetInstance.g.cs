#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaFeedbackCrashSubmissionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsBetaFeedbackCrashSubmissions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaFeedbackCrashSubmissionResponse> BetaFeedbackCrashSubmissionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission>? fieldsBetaFeedbackCrashSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackCrashSubmissionsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsBetaFeedbackCrashSubmissions"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsBetaTesters"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaFeedbackCrashSubmissionResponse>> BetaFeedbackCrashSubmissionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaFeedbackCrashSubmission>? fieldsBetaFeedbackCrashSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackCrashSubmissionsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackCrashSubmissionsGetInstanceFieldsBetaTester>? fieldsBetaTesters = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackCrashSubmissionsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}