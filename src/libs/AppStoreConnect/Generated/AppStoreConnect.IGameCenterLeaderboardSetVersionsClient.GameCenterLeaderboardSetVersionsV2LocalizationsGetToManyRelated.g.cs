#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterLeaderboardSetVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardSetLocalizations"></param>
        /// <param name="fieldsGameCenterLeaderboardSetVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardSetImages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2Response> GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>? fieldsGameCenterLeaderboardSetLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion>? fieldsGameCenterLeaderboardSetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage>? fieldsGameCenterLeaderboardSetImages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardSetLocalizations"></param>
        /// <param name="fieldsGameCenterLeaderboardSetVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardSetImages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2Response>> GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetLocalization>? fieldsGameCenterLeaderboardSetLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion>? fieldsGameCenterLeaderboardSetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardSetImage>? fieldsGameCenterLeaderboardSetImages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetVersionsV2LocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}