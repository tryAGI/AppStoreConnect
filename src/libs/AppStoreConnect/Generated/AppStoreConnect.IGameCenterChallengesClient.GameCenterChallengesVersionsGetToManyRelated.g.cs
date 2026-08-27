#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterChallengesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterChallengeVersions"></param>
        /// <param name="fieldsGameCenterChallenges"></param>
        /// <param name="fieldsGameCenterChallengeLocalizations"></param>
        /// <param name="fieldsGameCenterChallengeVersionReleases"></param>
        /// <param name="fieldsGameCenterChallengeImages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="limitReleases"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterChallengeVersionsResponse> GameCenterChallengesVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion>? fieldsGameCenterChallengeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization>? fieldsGameCenterChallengeLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage>? fieldsGameCenterChallengeImages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedIncludeItem>? include = default,
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
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="limitReleases"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterChallengeVersionsResponse>> GameCenterChallengesVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion>? fieldsGameCenterChallengeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallenge>? fieldsGameCenterChallenges = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization>? fieldsGameCenterChallengeLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionRelease>? fieldsGameCenterChallengeVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeImage>? fieldsGameCenterChallengeImages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengesVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            int? limitReleases = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}