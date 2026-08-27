#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiBuildActionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiBuildActions"></param>
        /// <param name="fieldsCiBuildRuns"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiBuildActionResponse> CiBuildActionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction>? fieldsCiBuildActions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun>? fieldsCiBuildRuns = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiBuildActions"></param>
        /// <param name="fieldsCiBuildRuns"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiBuildActionResponse>> CiBuildActionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildAction>? fieldsCiBuildActions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceFieldsCiBuildRun>? fieldsCiBuildRuns = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildActionsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}