#nullable enable

namespace AppStoreConnect
{
    public partial interface IScmPullRequestsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsScmPullRequests"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ScmPullRequestResponse> ScmPullRequestsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmPullRequest>? fieldsScmPullRequests = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmPullRequestsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsScmPullRequests"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ScmPullRequestResponse>> ScmPullRequestsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmPullRequest>? fieldsScmPullRequests = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmPullRequestsGetInstanceFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmPullRequestsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}