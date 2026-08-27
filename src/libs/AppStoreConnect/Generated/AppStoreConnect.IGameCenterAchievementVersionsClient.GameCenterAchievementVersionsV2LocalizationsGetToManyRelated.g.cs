#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterAchievementVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterAchievementLocalizations"></param>
        /// <param name="fieldsGameCenterAchievementVersions"></param>
        /// <param name="fieldsGameCenterAchievementImages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterAchievementLocalizationsV2Response> GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization>? fieldsGameCenterAchievementLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion>? fieldsGameCenterAchievementVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage>? fieldsGameCenterAchievementImages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterAchievementLocalizations"></param>
        /// <param name="fieldsGameCenterAchievementVersions"></param>
        /// <param name="fieldsGameCenterAchievementImages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterAchievementLocalizationsV2Response>> GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementLocalization>? fieldsGameCenterAchievementLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementVersion>? fieldsGameCenterAchievementVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterAchievementImage>? fieldsGameCenterAchievementImages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementVersionsV2LocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}