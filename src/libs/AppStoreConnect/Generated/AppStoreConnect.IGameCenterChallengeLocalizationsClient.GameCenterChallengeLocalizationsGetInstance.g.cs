#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterChallengeLocalizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterChallengeLocalizations"></param>
        /// <param name="fieldsGameCenterChallengeVersions"></param>
        /// <param name="fieldsGameCenterChallengeImages"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterChallengeLocalizationResponse> GameCenterChallengeLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization>? fieldsGameCenterChallengeLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion>? fieldsGameCenterChallengeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage>? fieldsGameCenterChallengeImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterChallengeLocalizations"></param>
        /// <param name="fieldsGameCenterChallengeVersions"></param>
        /// <param name="fieldsGameCenterChallengeImages"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterChallengeLocalizationResponse>> GameCenterChallengeLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization>? fieldsGameCenterChallengeLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion>? fieldsGameCenterChallengeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeImage>? fieldsGameCenterChallengeImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}