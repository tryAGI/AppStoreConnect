#nullable enable

namespace AppStoreConnect
{
    public partial interface IAlternativeDistributionPackageVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackageVariants"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AlternativeDistributionPackageVariantsResponse> AlternativeDistributionPackageVersionsVariantsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant>? fieldsAlternativeDistributionPackageVariants = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackageVariants"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AlternativeDistributionPackageVariantsResponse>> AlternativeDistributionPackageVersionsVariantsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant>? fieldsAlternativeDistributionPackageVariants = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Wraps AlternativeDistributionPackageVersionsVariantsGetToManyRelatedAsync as an IAsyncEnumerable&lt;global::AppStoreConnect.AlternativeDistributionPackageVariant&gt; that follows the response's next-page URL.
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackageVariants"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Options forwarded to every page request.</param>
        /// <param name="cancellationToken"></param>
        global::System.Collections.Generic.IAsyncEnumerable<global::AppStoreConnect.AlternativeDistributionPackageVariant> AlternativeDistributionPackageVersionsVariantsGetToManyRelatedAutoPagingAsync(
            string id,             global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsVariantsGetToManyRelatedFieldsAlternativeDistributionPackageVariant>? fieldsAlternativeDistributionPackageVariants = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = null,
            global::System.Threading.CancellationToken cancellationToken = default);

    }
}