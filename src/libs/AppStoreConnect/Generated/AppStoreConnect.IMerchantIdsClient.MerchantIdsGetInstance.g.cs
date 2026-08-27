#nullable enable

namespace AppStoreConnect
{
    public partial interface IMerchantIdsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsMerchantIds"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.MerchantIdResponse> MerchantIdsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetInstanceFieldsMerchantId>? fieldsMerchantIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetInstanceFieldsCertificate>? fieldsCertificates = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetInstanceIncludeItem>? include = default,
            int? limitCertificates = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsMerchantIds"></param>
        /// <param name="fieldsCertificates"></param>
        /// <param name="include"></param>
        /// <param name="limitCertificates"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.MerchantIdResponse>> MerchantIdsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetInstanceFieldsMerchantId>? fieldsMerchantIds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetInstanceFieldsCertificate>? fieldsCertificates = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.MerchantIdsGetInstanceIncludeItem>? include = default,
            int? limitCertificates = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}