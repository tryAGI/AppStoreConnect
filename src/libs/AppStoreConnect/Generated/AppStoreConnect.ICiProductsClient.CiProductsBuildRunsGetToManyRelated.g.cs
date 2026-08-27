#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiProductsClient
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiBuildRunsResponse> CiProductsBuildRunsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun>? fieldsCiBuildRuns = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow>? fieldsCiWorkflows = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference>? fieldsScmGitReferences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest>? fieldsScmPullRequests = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem>? include = default,
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
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiBuildRunsResponse>> CiProductsBuildRunsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiBuildRun>? fieldsCiBuildRuns = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiWorkflow>? fieldsCiWorkflows = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmGitReference>? fieldsScmGitReferences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedFieldsScmPullRequest>? fieldsScmPullRequests = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsBuildRunsGetToManyRelatedIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}