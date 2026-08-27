#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterActivityVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterActivityVersions"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterActivityLocalizations"></param>
        /// <param name="fieldsGameCenterActivityImages"></param>
        /// <param name="fieldsGameCenterActivityVersionReleases"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="limitReleases"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterActivityVersionResponse> GameCenterActivityVersionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion>? fieldsGameCenterActivityVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization>? fieldsGameCenterActivityLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage>? fieldsGameCenterActivityImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersionRelease>? fieldsGameCenterActivityVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            int? limitReleases = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsGameCenterActivityVersions"></param>
        /// <param name="fieldsGameCenterActivities"></param>
        /// <param name="fieldsGameCenterActivityLocalizations"></param>
        /// <param name="fieldsGameCenterActivityImages"></param>
        /// <param name="fieldsGameCenterActivityVersionReleases"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="limitReleases"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterActivityVersionResponse>> GameCenterActivityVersionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersion>? fieldsGameCenterActivityVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceFieldsGameCenterActivitie>? fieldsGameCenterActivities = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization>? fieldsGameCenterActivityLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityImage>? fieldsGameCenterActivityImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityVersionRelease>? fieldsGameCenterActivityVersionReleases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterActivityVersionsGetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            int? limitReleases = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}