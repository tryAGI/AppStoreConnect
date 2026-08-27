#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiMacOsVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiXcodeVersions"></param>
        /// <param name="fieldsCiMacOsVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitMacOsVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiXcodeVersionsResponse> CiMacOsVersionsXcodeVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsXcodeVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitMacOsVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiXcodeVersions"></param>
        /// <param name="fieldsCiMacOsVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitMacOsVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiXcodeVersionsResponse>> CiMacOsVersionsXcodeVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsXcodeVersionsGetToManyRelatedFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsXcodeVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitMacOsVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}