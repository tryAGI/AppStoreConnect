#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaFeedbackCrashSubmissionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaCrashLogs"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaCrashLogResponse> BetaFeedbackCrashSubmissionsCrashLogGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackCrashSubmissionsCrashLogGetToOneRelatedFieldsBetaCrashLog>? fieldsBetaCrashLogs = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsBetaCrashLogs"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaCrashLogResponse>> BetaFeedbackCrashSubmissionsCrashLogGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaFeedbackCrashSubmissionsCrashLogGetToOneRelatedFieldsBetaCrashLog>? fieldsBetaCrashLogs = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}