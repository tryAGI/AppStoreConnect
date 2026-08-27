#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterAchievementLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterAchievementImages"></param>
        /// <param name="fieldsGameCenterAchievementLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterAchievementImageV2Response> GameCenterAchievementLocalizationsV2ImageGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage>? fieldsGameCenterAchievementImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization>? fieldsGameCenterAchievementLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2ImageGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterAchievementImages"></param>
        /// <param name="fieldsGameCenterAchievementLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterAchievementImageV2Response>> GameCenterAchievementLocalizationsV2ImageGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementImage>? fieldsGameCenterAchievementImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2ImageGetToOneRelatedFieldsGameCenterAchievementLocalization>? fieldsGameCenterAchievementLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAchievementLocalizationsV2ImageGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}