#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterLeaderboardSetVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardSetVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterLeaderboardSetLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Response> GameCenterLeaderboardSetVersionsV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion>? fieldsGameCenterLeaderboardSetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization>? fieldsGameCenterLeaderboardSetLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2GetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardSetVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterLeaderboardSetLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterLeaderboardSetVersionV2Response>> GameCenterLeaderboardSetVersionsV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetVersion>? fieldsGameCenterLeaderboardSetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization>? fieldsGameCenterLeaderboardSetLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2GetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}