#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterDetailsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterEnabled"></param>
        /// <param name="fieldsGameCenterAppVersions"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitCompatibilityVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterAppVersionsResponse> GameCenterDetailsGameCenterAppVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterEnabled = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitCompatibilityVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterEnabled"></param>
        /// <param name="fieldsGameCenterAppVersions"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitCompatibilityVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterAppVersionsResponse>> GameCenterDetailsGameCenterAppVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterEnabled = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterDetailsGameCenterAppVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitCompatibilityVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}