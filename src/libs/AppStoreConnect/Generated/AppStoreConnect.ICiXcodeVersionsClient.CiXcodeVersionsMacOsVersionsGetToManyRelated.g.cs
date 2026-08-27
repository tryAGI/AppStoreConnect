#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiXcodeVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiMacOsVersions"></param>
        /// <param name="fieldsCiXcodeVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitXcodeVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiMacOsVersionsResponse> CiXcodeVersionsMacOsVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsMacOsVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitXcodeVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiMacOsVersions"></param>
        /// <param name="fieldsCiXcodeVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitXcodeVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiMacOsVersionsResponse>> CiXcodeVersionsMacOsVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsMacOsVersionsGetToManyRelatedFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsMacOsVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitXcodeVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}