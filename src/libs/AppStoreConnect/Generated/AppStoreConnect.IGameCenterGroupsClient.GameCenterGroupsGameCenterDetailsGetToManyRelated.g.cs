#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterGroupsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGameCenterAppVersionsEnabled"></param>
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
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitGameCenterAppVersions"></param>
        /// <param name="limitGameCenterLeaderboards"></param>
        /// <param name="limitGameCenterLeaderboardsV2"></param>
        /// <param name="limitGameCenterLeaderboardSets"></param>
        /// <param name="limitGameCenterLeaderboardSetsV2"></param>
        /// <param name="limitGameCenterAchievements"></param>
        /// <param name="limitGameCenterAchievementsV2"></param>
        /// <param name="limitGameCenterActivities"></param>
        /// <param name="limitGameCenterChallenges"></param>
        /// <param name="limitAchievementReleases"></param>
        /// <param name="limitActivityReleases"></param>
        /// <param name="limitChallengeReleases"></param>
        /// <param name="limitLeaderboardReleases"></param>
        /// <param name="limitLeaderboardSetReleases"></param>
        /// <param name="limitChallengesMinimumPlatformVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterDetailsResponse> GameCenterGroupsGameCenterDetailsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterGameCenterAppVersionsEnabled = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease>? fieldsGameCenterAchievementReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease>? fieldsGameCenterActivityVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease>? fieldsGameCenterLeaderboardReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>? fieldsGameCenterLeaderboardSetReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem>? include = default,
            int? limitGameCenterAppVersions = default,
            int? limitGameCenterLeaderboards = default,
            int? limitGameCenterLeaderboardsV2 = default,
            int? limitGameCenterLeaderboardSets = default,
            int? limitGameCenterLeaderboardSetsV2 = default,
            int? limitGameCenterAchievements = default,
            int? limitGameCenterAchievementsV2 = default,
            int? limitGameCenterActivities = default,
            int? limitGameCenterChallenges = default,
            int? limitAchievementReleases = default,
            int? limitActivityReleases = default,
            int? limitChallengeReleases = default,
            int? limitLeaderboardReleases = default,
            int? limitLeaderboardSetReleases = default,
            int? limitChallengesMinimumPlatformVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGameCenterAppVersionsEnabled"></param>
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
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitGameCenterAppVersions"></param>
        /// <param name="limitGameCenterLeaderboards"></param>
        /// <param name="limitGameCenterLeaderboardsV2"></param>
        /// <param name="limitGameCenterLeaderboardSets"></param>
        /// <param name="limitGameCenterLeaderboardSetsV2"></param>
        /// <param name="limitGameCenterAchievements"></param>
        /// <param name="limitGameCenterAchievementsV2"></param>
        /// <param name="limitGameCenterActivities"></param>
        /// <param name="limitGameCenterChallenges"></param>
        /// <param name="limitAchievementReleases"></param>
        /// <param name="limitActivityReleases"></param>
        /// <param name="limitChallengeReleases"></param>
        /// <param name="limitLeaderboardReleases"></param>
        /// <param name="limitLeaderboardSetReleases"></param>
        /// <param name="limitChallengesMinimumPlatformVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterDetailsResponse>> GameCenterGroupsGameCenterDetailsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterGameCenterAppVersionsEnabled = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSet>? fieldsGameCenterLeaderboardSets = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterAchievementRelease>? fieldsGameCenterAchievementReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterActivityVersionRelease>? fieldsGameCenterActivityVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardRelease>? fieldsGameCenterLeaderboardReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsGameCenterLeaderboardSetRelease>? fieldsGameCenterLeaderboardSetReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterDetailsGetToManyRelatedIncludeItem>? include = default,
            int? limitGameCenterAppVersions = default,
            int? limitGameCenterLeaderboards = default,
            int? limitGameCenterLeaderboardsV2 = default,
            int? limitGameCenterLeaderboardSets = default,
            int? limitGameCenterLeaderboardSetsV2 = default,
            int? limitGameCenterAchievements = default,
            int? limitGameCenterAchievementsV2 = default,
            int? limitGameCenterActivities = default,
            int? limitGameCenterChallenges = default,
            int? limitAchievementReleases = default,
            int? limitActivityReleases = default,
            int? limitChallengeReleases = default,
            int? limitLeaderboardReleases = default,
            int? limitLeaderboardSetReleases = default,
            int? limitChallengesMinimumPlatformVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}