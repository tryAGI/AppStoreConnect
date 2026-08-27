#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterChallengeVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterChallengeVersions"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="fieldsGameCenterChallengeLocalizations"></param>
        /// <param name="fieldsGameCenterChallengeVersionReleases"></param>
        /// <param name="fieldsGameCenterChallengeImages"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="limitReleases"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterChallengeVersionResponse> GameCenterChallengeVersionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion>? fieldsGameCenterChallengeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization>? fieldsGameCenterChallengeLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage>? fieldsGameCenterChallengeImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            int? limitReleases = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterChallengeVersions"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="fieldsGameCenterChallengeLocalizations"></param>
        /// <param name="fieldsGameCenterChallengeVersionReleases"></param>
        /// <param name="fieldsGameCenterChallengeImages"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="limitReleases"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterChallengeVersionResponse>> GameCenterChallengeVersionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion>? fieldsGameCenterChallengeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization>? fieldsGameCenterChallengeLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeImage>? fieldsGameCenterChallengeImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsGetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            int? limitReleases = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}