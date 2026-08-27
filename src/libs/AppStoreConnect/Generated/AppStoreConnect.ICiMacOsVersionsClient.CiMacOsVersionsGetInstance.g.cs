#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiMacOsVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiMacOsVersions"></param>
        /// <param name="fieldsCiXcodeVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitXcodeVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiMacOsVersionResponse> CiMacOsVersionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetInstanceFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetInstanceFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetInstanceIncludeItem>? include = default,
            int? limitXcodeVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiMacOsVersions"></param>
        /// <param name="fieldsCiXcodeVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitXcodeVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiMacOsVersionResponse>> CiMacOsVersionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetInstanceFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetInstanceFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetInstanceIncludeItem>? include = default,
            int? limitXcodeVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}