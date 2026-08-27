#nullable enable

namespace AppStoreConnect
{
    public partial interface IBetaAppClipInvocationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsBetaAppClipInvocations"></param>
        /// <param name="fieldsBetaAppClipInvocationLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitBetaAppClipInvocationLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.BetaAppClipInvocationResponse> BetaAppClipInvocationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation>? fieldsBetaAppClipInvocations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization>? fieldsBetaAppClipInvocationLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceIncludeItem>? include = default,
            int? limitBetaAppClipInvocationLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsBetaAppClipInvocations"></param>
        /// <param name="fieldsBetaAppClipInvocationLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitBetaAppClipInvocationLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.BetaAppClipInvocationResponse>> BetaAppClipInvocationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocation>? fieldsBetaAppClipInvocations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceFieldsBetaAppClipInvocationLocalization>? fieldsBetaAppClipInvocationLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.BetaAppClipInvocationsGetInstanceIncludeItem>? include = default,
            int? limitBetaAppClipInvocationLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}