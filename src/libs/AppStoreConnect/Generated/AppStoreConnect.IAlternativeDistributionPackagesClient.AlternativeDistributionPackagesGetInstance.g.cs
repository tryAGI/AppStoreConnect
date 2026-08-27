#nullable enable

namespace AppStoreConnect
{
    public partial interface IAlternativeDistributionPackagesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackages"></param>
        /// <param name="fieldsAlternativeDistributionPackageVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AlternativeDistributionPackageResponse> AlternativeDistributionPackagesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion>? fieldsAlternativeDistributionPackageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesGetInstanceIncludeItem>? include = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackages"></param>
        /// <param name="fieldsAlternativeDistributionPackageVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AlternativeDistributionPackageResponse>> AlternativeDistributionPackagesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesGetInstanceFieldsAlternativeDistributionPackageVersion>? fieldsAlternativeDistributionPackageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesGetInstanceIncludeItem>? include = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}