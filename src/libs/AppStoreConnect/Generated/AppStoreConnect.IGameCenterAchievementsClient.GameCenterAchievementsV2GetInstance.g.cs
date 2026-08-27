#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterAchievementsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterAchievementVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterAchievementV2Response> GameCenterAchievementsV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion>? fieldsGameCenterAchievementVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceIncludeItem>? include = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterDetails"></param>
        /// <param name="fieldsGameCenterGroups"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterAchievementVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterAchievementV2Response>> GameCenterAchievementsV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterDetail>? fieldsGameCenterDetails = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterGroup>? fieldsGameCenterGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceFieldsGameCenterAchievementVersion>? fieldsGameCenterAchievementVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2GetInstanceIncludeItem>? include = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}