#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterAchievementLocalizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterAchievementLocalizations"></param>
        /// <param name="fieldsGameCenterAchievementVersions"></param>
        /// <param name="fieldsGameCenterAchievementImages"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterAchievementLocalizationV2Response> GameCenterAchievementLocalizationsV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization>? fieldsGameCenterAchievementLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion>? fieldsGameCenterAchievementVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage>? fieldsGameCenterAchievementImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterAchievementLocalizations"></param>
        /// <param name="fieldsGameCenterAchievementVersions"></param>
        /// <param name="fieldsGameCenterAchievementImages"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterAchievementLocalizationV2Response>> GameCenterAchievementLocalizationsV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementLocalization>? fieldsGameCenterAchievementLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementVersion>? fieldsGameCenterAchievementVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2GetInstanceFieldsGameCenterAchievementImage>? fieldsGameCenterAchievementImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}