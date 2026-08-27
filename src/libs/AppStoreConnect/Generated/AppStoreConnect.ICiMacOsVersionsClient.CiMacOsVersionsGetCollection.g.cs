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
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitXcodeVersions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiMacOsVersionsResponse> CiMacOsVersionsGetCollectionAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetCollectionFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetCollectionFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetCollectionIncludeItem>? include = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiMacOsVersionsResponse>> CiMacOsVersionsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetCollectionFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetCollectionFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiMacOsVersionsGetCollectionIncludeItem>? include = default,
            int? limitXcodeVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}