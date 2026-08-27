#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterAchievementsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterAchievementVersions"></param>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterAchievementLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterAchievementVersionsV2Response> GameCenterAchievementsV2VersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion>? fieldsGameCenterAchievementVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization>? fieldsGameCenterAchievementLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterAchievementVersions"></param>
        /// <param name="fieldsGameCenterAchievements"></param>
        /// <param name="fieldsGameCenterAchievementLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterAchievementVersionsV2Response>> GameCenterAchievementsV2VersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementVersion>? fieldsGameCenterAchievementVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievement>? fieldsGameCenterAchievements = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedFieldsGameCenterAchievementLocalization>? fieldsGameCenterAchievementLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementsV2VersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}