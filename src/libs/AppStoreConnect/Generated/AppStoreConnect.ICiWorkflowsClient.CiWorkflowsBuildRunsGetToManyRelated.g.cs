#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiWorkflowsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterBuilds"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsCiBuildRuns"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsCiWorkflows"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsScmGitReferences"></param>
        /// <param name="fieldsScmPullRequests"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiBuildRunsResponse> CiWorkflowsBuildRunsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun>? fieldsCiBuildRuns = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow>? fieldsCiWorkflows = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference>? fieldsScmGitReferences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest>? fieldsScmPullRequests = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterBuilds"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsCiBuildRuns"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsCiWorkflows"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsScmGitReferences"></param>
        /// <param name="fieldsScmPullRequests"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiBuildRunsResponse>> CiWorkflowsBuildRunsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiBuildRun>? fieldsCiBuildRuns = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiWorkflow>? fieldsCiWorkflows = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmGitReference>? fieldsScmGitReferences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedFieldsScmPullRequest>? fieldsScmPullRequests = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsBuildRunsGetToManyRelatedIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}