#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiBuildRunsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsCiBuildActions"></param>
        /// <param name="fieldsCiBuildRuns"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiBuildActionsResponse> CiBuildRunsActionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction>? fieldsCiBuildActions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun>? fieldsCiBuildRuns = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsCiBuildActions"></param>
        /// <param name="fieldsCiBuildRuns"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiBuildActionsResponse>> CiBuildRunsActionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildAction>? fieldsCiBuildActions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedFieldsCiBuildRun>? fieldsCiBuildRuns = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsActionsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}