#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterLeaderboardSetLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardSetLocalizations"></param>
        /// <param name="fieldsGameCenterLeaderboardSetVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardSetImages"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2Response> GameCenterLeaderboardSetLocalizationsV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization>? fieldsGameCenterLeaderboardSetLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion>? fieldsGameCenterLeaderboardSetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage>? fieldsGameCenterLeaderboardSetImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardSetLocalizations"></param>
        /// <param name="fieldsGameCenterLeaderboardSetVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardSetImages"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationV2Response>> GameCenterLeaderboardSetLocalizationsV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetLocalization>? fieldsGameCenterLeaderboardSetLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetVersion>? fieldsGameCenterLeaderboardSetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2GetInstanceFieldsGameCenterLeaderboardSetImage>? fieldsGameCenterLeaderboardSetImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardSetLocalizationsV2GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}