#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterGroupsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="include"></param>
        /// <param name="limitGameCenterAchievements"></param>
        /// <param name="limitGameCenterAchievementsV2"></param>
        /// <param name="limitGameCenterActivities"></param>
        /// <param name="limitGameCenterChallenges"></param>
        /// <param name="limitGameCenterDetails"></param>
        /// <param name="limitGameCenterLeaderboardSets"></param>
        /// <param name="limitGameCenterLeaderboardSetsV2"></param>
        /// <param name="limitGameCenterLeaderboards"></param>
        /// <param name="limitGameCenterLeaderboardsV2"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterGroupResponse> GameCenterGroupsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceIncludeItem>? include = default,
            int? limitGameCenterAchievements = default,
            int? limitGameCenterAchievementsV2 = default,
            int? limitGameCenterActivities = default,
            int? limitGameCenterChallenges = default,
            int? limitGameCenterDetails = default,
            int? limitGameCenterLeaderboardSets = default,
            int? limitGameCenterLeaderboardSetsV2 = default,
            int? limitGameCenterLeaderboards = default,
            int? limitGameCenterLeaderboardsV2 = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="include"></param>
        /// <param name="limitGameCenterAchievements"></param>
        /// <param name="limitGameCenterAchievementsV2"></param>
        /// <param name="limitGameCenterActivities"></param>
        /// <param name="limitGameCenterChallenges"></param>
        /// <param name="limitGameCenterDetails"></param>
        /// <param name="limitGameCenterLeaderboardSets"></param>
        /// <param name="limitGameCenterLeaderboardSetsV2"></param>
        /// <param name="limitGameCenterLeaderboards"></param>
        /// <param name="limitGameCenterLeaderboardsV2"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterGroupResponse>> GameCenterGroupsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGetInstanceIncludeItem>? include = default,
            int? limitGameCenterAchievements = default,
            int? limitGameCenterAchievementsV2 = default,
            int? limitGameCenterActivities = default,
            int? limitGameCenterChallenges = default,
            int? limitGameCenterDetails = default,
            int? limitGameCenterLeaderboardSets = default,
            int? limitGameCenterLeaderboardSetsV2 = default,
            int? limitGameCenterLeaderboards = default,
            int? limitGameCenterLeaderboardsV2 = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}