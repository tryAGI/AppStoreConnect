#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterDetailsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsGameCenterAppVersions"></param>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="fieldsGameCenterAchievementReleases"></param>
        /// <param name="fieldsGameCenterActivityVersionReleases"></param>
        /// <param name="fieldsGameCenterChallengeVersionReleases"></param>
        /// <param name="fieldsGameCenterLeaderboardReleases"></param>
        /// <param name="fieldsGameCenterLeaderboardSetReleases"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitAchievementReleases"></param>
        /// <param name="limitActivityReleases"></param>
        /// <param name="limitChallengeReleases"></param>
        /// <param name="limitChallengesMinimumPlatformVersions"></param>
        /// <param name="limitGameCenterAchievements"></param>
        /// <param name="limitGameCenterAchievementsV2"></param>
        /// <param name="limitGameCenterActivities"></param>
        /// <param name="limitGameCenterAppVersions"></param>
        /// <param name="limitGameCenterChallenges"></param>
        /// <param name="limitGameCenterLeaderboardSets"></param>
        /// <param name="limitGameCenterLeaderboardSetsV2"></param>
        /// <param name="limitGameCenterLeaderboards"></param>
        /// <param name="limitGameCenterLeaderboardsV2"></param>
        /// <param name="limitLeaderboardReleases"></param>
        /// <param name="limitLeaderboardSetReleases"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterDetailResponse> GameCenterDetailsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease>? fieldsGameCenterAchievementReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease>? fieldsGameCenterActivityVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease>? fieldsGameCenterLeaderboardReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease>? fieldsGameCenterLeaderboardSetReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceIncludeItem>? include = default,
            int? limitAchievementReleases = default,
            int? limitActivityReleases = default,
            int? limitChallengeReleases = default,
            int? limitChallengesMinimumPlatformVersions = default,
            int? limitGameCenterAchievements = default,
            int? limitGameCenterAchievementsV2 = default,
            int? limitGameCenterActivities = default,
            int? limitGameCenterAppVersions = default,
            int? limitGameCenterChallenges = default,
            int? limitGameCenterLeaderboardSets = default,
            int? limitGameCenterLeaderboardSetsV2 = default,
            int? limitGameCenterLeaderboards = default,
            int? limitGameCenterLeaderboardsV2 = default,
            int? limitLeaderboardReleases = default,
            int? limitLeaderboardSetReleases = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsGameCenterAppVersions"></param>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterLeaderboardSets"></param>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="fieldsGameCenterAchievementReleases"></param>
        /// <param name="fieldsGameCenterActivityVersionReleases"></param>
        /// <param name="fieldsGameCenterChallengeVersionReleases"></param>
        /// <param name="fieldsGameCenterLeaderboardReleases"></param>
        /// <param name="fieldsGameCenterLeaderboardSetReleases"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitAchievementReleases"></param>
        /// <param name="limitActivityReleases"></param>
        /// <param name="limitChallengeReleases"></param>
        /// <param name="limitChallengesMinimumPlatformVersions"></param>
        /// <param name="limitGameCenterAchievements"></param>
        /// <param name="limitGameCenterAchievementsV2"></param>
        /// <param name="limitGameCenterActivities"></param>
        /// <param name="limitGameCenterAppVersions"></param>
        /// <param name="limitGameCenterChallenges"></param>
        /// <param name="limitGameCenterLeaderboardSets"></param>
        /// <param name="limitGameCenterLeaderboardSetsV2"></param>
        /// <param name="limitGameCenterLeaderboards"></param>
        /// <param name="limitGameCenterLeaderboardsV2"></param>
        /// <param name="limitLeaderboardReleases"></param>
        /// <param name="limitLeaderboardSetReleases"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterDetailResponse>> GameCenterDetailsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterAchievementRelease>? fieldsGameCenterAchievementReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterActivityVersionRelease>? fieldsGameCenterActivityVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardRelease>? fieldsGameCenterLeaderboardReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsGameCenterLeaderboardSetRelease>? fieldsGameCenterLeaderboardSetReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGetInstanceIncludeItem>? include = default,
            int? limitAchievementReleases = default,
            int? limitActivityReleases = default,
            int? limitChallengeReleases = default,
            int? limitChallengesMinimumPlatformVersions = default,
            int? limitGameCenterAchievements = default,
            int? limitGameCenterAchievementsV2 = default,
            int? limitGameCenterActivities = default,
            int? limitGameCenterAppVersions = default,
            int? limitGameCenterChallenges = default,
            int? limitGameCenterLeaderboardSets = default,
            int? limitGameCenterLeaderboardSetsV2 = default,
            int? limitGameCenterLeaderboards = default,
            int? limitGameCenterLeaderboardsV2 = default,
            int? limitLeaderboardReleases = default,
            int? limitLeaderboardSetReleases = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}