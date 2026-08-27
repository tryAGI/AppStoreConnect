#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterGroupsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterReferenceName"></param>
        /// <param name="filterArchived"></param>
        /// <param name="filterId"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="fieldsGameCenterLeaderboardVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitGameCenterLeaderboardSets"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterLeaderboardsV2Response> GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterReferenceName = default,
            global::System.Collections.Generic.IList<string>? filterArchived = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion>? fieldsGameCenterLeaderboardVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem>? include = default,
            int? limitGameCenterLeaderboardSets = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterReferenceName"></param>
        /// <param name="filterArchived"></param>
        /// <param name="filterId"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="fieldsGameCenterLeaderboardVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitGameCenterLeaderboardSets"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterLeaderboardsV2Response>> GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterReferenceName = default,
            global::System.Collections.Generic.IList<string>? filterArchived = default,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedFieldsGameCenterLeaderboardVersion>? fieldsGameCenterLeaderboardVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterLeaderboardsV2GetToManyRelatedIncludeItem>? include = default,
            int? limitGameCenterLeaderboardSets = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}