#nullable enable

namespace AppStoreConnect
{
    public partial interface IAlternativeDistributionPackagesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterState"></param>
        /// <param name="fieldsAlternativeDistributionPackageVersions"></param>
        /// <param name="fieldsAlternativeDistributionPackageVariants"></param>
        /// <param name="fieldsAlternativeDistributionPackageDeltas"></param>
        /// <param name="fieldsAlternativeDistributionPackages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitVariants"></param>
        /// <param name="limitDeltas"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AlternativeDistributionPackageVersionsResponse> AlternativeDistributionPackagesVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion>? fieldsAlternativeDistributionPackageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant>? fieldsAlternativeDistributionPackageVariants = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta>? fieldsAlternativeDistributionPackageDeltas = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitVariants = default,
            int? limitDeltas = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterState"></param>
        /// <param name="fieldsAlternativeDistributionPackageVersions"></param>
        /// <param name="fieldsAlternativeDistributionPackageVariants"></param>
        /// <param name="fieldsAlternativeDistributionPackageDeltas"></param>
        /// <param name="fieldsAlternativeDistributionPackages"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitVariants"></param>
        /// <param name="limitDeltas"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AlternativeDistributionPackageVersionsResponse>> AlternativeDistributionPackagesVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVersion>? fieldsAlternativeDistributionPackageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageVariant>? fieldsAlternativeDistributionPackageVariants = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackageDelta>? fieldsAlternativeDistributionPackageDeltas = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedFieldsAlternativeDistributionPackage>? fieldsAlternativeDistributionPackages = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackagesVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitVariants = default,
            int? limitDeltas = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}