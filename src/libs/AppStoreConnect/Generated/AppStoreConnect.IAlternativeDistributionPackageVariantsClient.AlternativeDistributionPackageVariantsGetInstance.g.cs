#nullable enable

namespace AppStoreConnect
{
    public partial interface IAlternativeDistributionPackageVariantsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackageVariants"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AlternativeDistributionPackageVariantResponse> AlternativeDistributionPackageVariantsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant>? fieldsAlternativeDistributionPackageVariants = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackageVariants"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AlternativeDistributionPackageVariantResponse>> AlternativeDistributionPackageVariantsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVariantsGetInstanceFieldsAlternativeDistributionPackageVariant>? fieldsAlternativeDistributionPackageVariants = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}