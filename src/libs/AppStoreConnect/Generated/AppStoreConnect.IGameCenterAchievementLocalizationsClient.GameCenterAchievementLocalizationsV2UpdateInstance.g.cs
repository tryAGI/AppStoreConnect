#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterAchievementLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterAchievementLocalizationV2Response> GameCenterAchievementLocalizationsV2UpdateInstanceAsync(
            string id,

            global::AppStoreConnect.GameCenterAchievementLocalizationV2UpdateRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterAchievementLocalizationV2Response>> GameCenterAchievementLocalizationsV2UpdateInstanceAsResponseAsync(
            string id,

            global::AppStoreConnect.GameCenterAchievementLocalizationV2UpdateRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterAchievementLocalizationV2Response> GameCenterAchievementLocalizationsV2UpdateInstanceAsync(
            string id,
            global::AppStoreConnect.GameCenterAchievementLocalizationV2UpdateRequestData data,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}