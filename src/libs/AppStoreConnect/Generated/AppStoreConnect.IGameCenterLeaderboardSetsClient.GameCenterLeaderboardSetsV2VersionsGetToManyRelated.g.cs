#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterLeaderboardSetsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardSetVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterLeaderboardSetLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2Response> GameCenterLeaderboardSetsV2VersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion>? fieldsGameCenterLeaderboardSetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>? fieldsGameCenterLeaderboardSetLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardSetVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterLeaderboardSetLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2Response>> GameCenterLeaderboardSetsV2VersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion>? fieldsGameCenterLeaderboardSetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>? fieldsGameCenterLeaderboardSetLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetsV2VersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}