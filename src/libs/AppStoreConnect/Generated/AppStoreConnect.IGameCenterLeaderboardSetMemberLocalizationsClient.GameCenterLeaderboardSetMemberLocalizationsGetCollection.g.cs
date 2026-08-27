#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterLeaderboardSetMemberLocalizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGameCenterLeaderboardSet"></param>
        /// <param name="filterGameCenterLeaderboard"></param>
        /// <param name="fieldsGameCenterLeaderboardSetMemberLocalizations"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationsResponse> GameCenterLeaderboardSetMemberLocalizationsGetCollectionAsync(
            global::System.Collections.Generic.IList<string> filterGameCenterLeaderboardSet,
            global::System.Collections.Generic.IList<string> filterGameCenterLeaderboard,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization>? fieldsGameCenterLeaderboardSetMemberLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGameCenterLeaderboardSet"></param>
        /// <param name="filterGameCenterLeaderboard"></param>
        /// <param name="fieldsGameCenterLeaderboardSetMemberLocalizations"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationsResponse>> GameCenterLeaderboardSetMemberLocalizationsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string> filterGameCenterLeaderboardSet,
            global::System.Collections.Generic.IList<string> filterGameCenterLeaderboard,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSetMemberLocalization>? fieldsGameCenterLeaderboardSetMemberLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationsGetCollectionFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetMemberLocalizationsGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}