#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiBuildRunsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiBuildRuns"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsCiWorkflows"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsScmGitReferences"></param>
        /// <param name="fieldsScmPullRequests"></param>
        /// <param name="include"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiBuildRunResponse> CiBuildRunsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun>? fieldsCiBuildRuns = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow>? fieldsCiWorkflows = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference>? fieldsScmGitReferences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest>? fieldsScmPullRequests = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiBuildRuns"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsCiWorkflows"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsScmGitReferences"></param>
        /// <param name="fieldsScmPullRequests"></param>
        /// <param name="include"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiBuildRunResponse>> CiBuildRunsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiBuildRun>? fieldsCiBuildRuns = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiWorkflow>? fieldsCiWorkflows = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmGitReference>? fieldsScmGitReferences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceFieldsScmPullRequest>? fieldsScmPullRequests = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiBuildRunsGetInstanceIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}