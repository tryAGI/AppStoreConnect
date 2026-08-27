#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiXcodeVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsCiXcodeVersions"></param>
        /// <param name="fieldsCiMacOsVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitMacOsVersions"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiXcodeVersionsResponse> CiXcodeVersionsGetCollectionAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsGetCollectionFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsGetCollectionFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsGetCollectionIncludeItem>? include = default,
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiXcodeVersionsResponse>> CiXcodeVersionsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsGetCollectionFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsGetCollectionFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiXcodeVersionsGetCollectionIncludeItem>? include = default,
            int? limitMacOsVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}