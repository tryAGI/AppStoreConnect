#nullable enable

namespace AppStoreConnect
{
    public partial interface IGameCenterAppVersionsClient
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.GameCenterAppVersionsResponse> GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterEnabled = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedIncludeItem>? include = default,
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.GameCenterAppVersionsResponse>> GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterEnabled = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsGameCenterAppVersion>? fieldsGameCenterAppVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.GameCenterAppVersionsCompatibilityVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitCompatibilityVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}