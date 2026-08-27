#nullable enable

namespace AppStoreConnect
{
    public partial interface IScmRepositoriesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="fieldsScmProviders"></param>
        /// <param name="fieldsScmGitReferences"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ScmRepositoryResponse> ScmRepositoriesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGetInstanceFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGetInstanceFieldsScmProvider>? fieldsScmProviders = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGetInstanceFieldsScmGitReference>? fieldsScmGitReferences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="fieldsScmProviders"></param>
        /// <param name="fieldsScmGitReferences"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ScmRepositoryResponse>> ScmRepositoriesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGetInstanceFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGetInstanceFieldsScmProvider>? fieldsScmProviders = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGetInstanceFieldsScmGitReference>? fieldsScmGitReferences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}