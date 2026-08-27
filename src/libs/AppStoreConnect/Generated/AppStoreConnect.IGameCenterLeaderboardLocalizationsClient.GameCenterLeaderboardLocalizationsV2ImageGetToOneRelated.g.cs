#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterLeaderboardLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardImages"></param>
        /// <param name="fieldsGameCenterLeaderboardLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterLeaderboardImageV2Response> GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage>? fieldsGameCenterLeaderboardImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization>? fieldsGameCenterLeaderboardLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterLeaderboardImages"></param>
        /// <param name="fieldsGameCenterLeaderboardLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterLeaderboardImageV2Response>> GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardImage>? fieldsGameCenterLeaderboardImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedFieldsGameCenterLeaderboardLocalization>? fieldsGameCenterLeaderboardLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterLeaderboardLocalizationsV2ImageGetToOneRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}