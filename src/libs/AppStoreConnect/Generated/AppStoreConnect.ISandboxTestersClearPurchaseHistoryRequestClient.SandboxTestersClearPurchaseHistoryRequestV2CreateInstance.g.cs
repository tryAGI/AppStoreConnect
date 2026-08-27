#nullable enable

namespace AppStoreConnect
{
    public partial interface ISandboxTestersClearPurchaseHistoryRequestClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SandboxTestersClearPurchaseHistoryRequestV2Response> SandboxTestersClearPurchaseHistoryRequestV2CreateInstanceAsync(

            global::AppStoreConnect.SandboxTestersClearPurchaseHistoryRequestV2CreateRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SandboxTestersClearPurchaseHistoryRequestV2Response>> SandboxTestersClearPurchaseHistoryRequestV2CreateInstanceAsResponseAsync(

            global::AppStoreConnect.SandboxTestersClearPurchaseHistoryRequestV2CreateRequest request,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SandboxTestersClearPurchaseHistoryRequestV2Response> SandboxTestersClearPurchaseHistoryRequestV2CreateInstanceAsync(
            global::AppStoreConnect.SandboxTestersClearPurchaseHistoryRequestV2CreateRequestData data,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}