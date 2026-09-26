#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterLeaderboardsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="existsBlocked"></param>
        /// <param name="fieldsGameCenterScoreModerations"></param>
        /// <param name="fieldsGameCenterDetailPlayers"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterScoreModerationsResponse> GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedAsync(
            string id,
            bool? existsBlocked = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration>? fieldsGameCenterScoreModerations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer>? fieldsGameCenterDetailPlayers = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="existsBlocked"></param>
        /// <param name="fieldsGameCenterScoreModerations"></param>
        /// <param name="fieldsGameCenterDetailPlayers"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterScoreModerationsResponse>> GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedAsResponseAsync(
            string id,
            bool? existsBlocked = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterScoreModeration>? fieldsGameCenterScoreModerations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedFieldsGameCenterDetailPlayer>? fieldsGameCenterDetailPlayers = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2GameCenterScoreModerationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}