#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterLeaderboardSetImagesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardSetImages"></param>
        /// <param name="fieldsGameCenterLeaderboardSetLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterLeaderboardSetImageV2Response> GameCenterLeaderboardSetImagesV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage>? fieldsGameCenterLeaderboardSetImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization>? fieldsGameCenterLeaderboardSetLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetImagesV2GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardSetImages"></param>
        /// <param name="fieldsGameCenterLeaderboardSetLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterLeaderboardSetImageV2Response>> GameCenterLeaderboardSetImagesV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetImage>? fieldsGameCenterLeaderboardSetImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetImagesV2GetInstanceFieldsGameCenterLeaderboardSetLocalization>? fieldsGameCenterLeaderboardSetLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetImagesV2GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}