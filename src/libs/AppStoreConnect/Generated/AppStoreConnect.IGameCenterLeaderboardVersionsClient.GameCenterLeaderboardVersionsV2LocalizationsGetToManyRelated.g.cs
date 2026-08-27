#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterLeaderboardVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardLocalizations"></param>
        /// <param name="fieldsGameCenterLeaderboardVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardImages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2Response> GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization>? fieldsGameCenterLeaderboardLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion>? fieldsGameCenterLeaderboardVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage>? fieldsGameCenterLeaderboardImages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardLocalizations"></param>
        /// <param name="fieldsGameCenterLeaderboardVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardImages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2Response>> GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardLocalization>? fieldsGameCenterLeaderboardLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardVersion>? fieldsGameCenterLeaderboardVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedFieldsGameCenterLeaderboardImage>? fieldsGameCenterLeaderboardImages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardVersionsV2LocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}