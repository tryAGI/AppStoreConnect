#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterGroupsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterActivityVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAchievements"></param>
        /// <param name="limitAchievementsV2"></param>
        /// <param name="limitLeaderboards"></param>
        /// <param name="limitLeaderboardsV2"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterActivitiesResponse> GameCenterGroupsGameCenterActivitiesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion>? fieldsGameCenterActivityVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem>? include = default,
            int? limitAchievements = default,
            int? limitAchievementsV2 = default,
            int? limitLeaderboards = default,
            int? limitLeaderboardsV2 = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterLeaderboards"></param>
        /// <param name="fieldsGameCenterActivityVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAchievements"></param>
        /// <param name="limitAchievementsV2"></param>
        /// <param name="limitLeaderboards"></param>
        /// <param name="limitLeaderboardsV2"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterActivitiesResponse>> GameCenterGroupsGameCenterActivitiesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterLeaderboard>? fieldsGameCenterLeaderboards = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedFieldsGameCenterActivityVersion>? fieldsGameCenterActivityVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterGroupsGameCenterActivitiesGetToManyRelatedIncludeItem>? include = default,
            int? limitAchievements = default,
            int? limitAchievementsV2 = default,
            int? limitLeaderboards = default,
            int? limitLeaderboardsV2 = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}