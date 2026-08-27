#nullable enable

namespace AppStoreConnect
{
    public partial interface IAlternativeDistributionPackageVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackageVersions"></param>
        /// <param name="fieldsAlternativeDistributionPackageVariants"></param>
        /// <param name="fieldsAlternativeDistributionPackageDeltas"></param>
        /// <param name="fieldsAlternativeDistributionPackages"></param>
        /// <param name="include"></param>
        /// <param name="limitDeltas"></param>
        /// <param name="limitVariants"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AlternativeDistributionPackageVersionResponse> AlternativeDistributionPackageVersionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion>? fieldsAlternativeDistributionPackageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant>? fieldsAlternativeDistributionPackageVariants = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta>? fieldsAlternativeDistributionPackageDeltas = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsGetInstanceIncludeItem>? include = default,
            int? limitDeltas = default,
            int? limitVariants = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackageVersions"></param>
        /// <param name="fieldsAlternativeDistributionPackageVariants"></param>
        /// <param name="fieldsAlternativeDistributionPackageDeltas"></param>
        /// <param name="fieldsAlternativeDistributionPackages"></param>
        /// <param name="include"></param>
        /// <param name="limitDeltas"></param>
        /// <param name="limitVariants"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AlternativeDistributionPackageVersionResponse>> AlternativeDistributionPackageVersionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVersion>? fieldsAlternativeDistributionPackageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageVariant>? fieldsAlternativeDistributionPackageVariants = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackageDelta>? fieldsAlternativeDistributionPackageDeltas = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsGetInstanceFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsGetInstanceIncludeItem>? include = default,
            int? limitDeltas = default,
            int? limitVariants = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}