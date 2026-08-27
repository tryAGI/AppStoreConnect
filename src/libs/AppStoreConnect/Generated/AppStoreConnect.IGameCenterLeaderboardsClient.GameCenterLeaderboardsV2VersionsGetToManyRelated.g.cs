#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterLeaderboardsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardVersions"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterLeaderboardLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterLeaderboardVersionsV2Response> GameCenterLeaderboardsV2VersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion>? fieldsGameCenterLeaderboardVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization>? fieldsGameCenterLeaderboardLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2VersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardVersions"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterLeaderboardLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterLeaderboardVersionsV2Response>> GameCenterLeaderboardsV2VersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardVersion>? fieldsGameCenterLeaderboardVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardLocalization>? fieldsGameCenterLeaderboardLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardsV2VersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}