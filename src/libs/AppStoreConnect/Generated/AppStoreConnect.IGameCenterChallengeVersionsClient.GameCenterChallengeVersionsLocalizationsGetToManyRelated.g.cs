#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterChallengeVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterChallengeLocalizations"></param>
        /// <param name="fieldsGameCenterChallengeVersions"></param>
        /// <param name="fieldsGameCenterChallengeImages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterChallengeLocalizationsResponse> GameCenterChallengeVersionsLocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization>? fieldsGameCenterChallengeLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion>? fieldsGameCenterChallengeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage>? fieldsGameCenterChallengeImages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsGameCenterChallengeLocalizations"></param>
        /// <param name="fieldsGameCenterChallengeVersions"></param>
        /// <param name="fieldsGameCenterChallengeImages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterChallengeLocalizationsResponse>> GameCenterChallengeVersionsLocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization>? fieldsGameCenterChallengeLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion>? fieldsGameCenterChallengeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeImage>? fieldsGameCenterChallengeImages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}