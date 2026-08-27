#nullable enable

namespace AppStoreConnect
{
    public partial interface IAlternativeDistributionPackageVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackageDeltas"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AlternativeDistributionPackageDeltasResponse> AlternativeDistributionPackageVersionsDeltasGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta>? fieldsAlternativeDistributionPackageDeltas = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAlternativeDistributionPackageDeltas"></param>
        /// <param name="limit"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AlternativeDistributionPackageDeltasResponse>> AlternativeDistributionPackageVersionsDeltasGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AlternativeDistributionPackageVersionsDeltasGetToManyRelatedFieldsAlternativeDistributionPackageDelta>? fieldsAlternativeDistributionPackageDeltas = default,
            int? limit = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}