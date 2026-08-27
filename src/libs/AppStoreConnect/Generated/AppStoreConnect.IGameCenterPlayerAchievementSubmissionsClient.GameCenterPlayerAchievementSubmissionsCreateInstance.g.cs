#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterPlayerAchievementSubmissionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterPlayerAchievementSubmissionResponse> GameCenterPlayerAchievementSubmissionsCreateInstanceAsync(

            global::AppStoreConnect.GameCenterPlayerAchievementSubmissionCreateRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterPlayerAchievementSubmissionResponse>> GameCenterPlayerAchievementSubmissionsCreateInstanceAsResponseAsync(

            global::AppStoreConnect.GameCenterPlayerAchievementSubmissionCreateRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterPlayerAchievementSubmissionResponse> GameCenterPlayerAchievementSubmissionsCreateInstanceAsync(
            global::AppStoreConnect.GameCenterPlayerAchievementSubmissionCreateRequestData data,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}