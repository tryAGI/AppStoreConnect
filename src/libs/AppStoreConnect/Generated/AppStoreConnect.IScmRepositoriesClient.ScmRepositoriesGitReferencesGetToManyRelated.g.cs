#nullable enable

namespace AppStoreConnect
{
    public partial interface IScmRepositoriesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsScmGitReferences"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ScmGitReferencesResponse> ScmRepositoriesGitReferencesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference>? fieldsScmGitReferences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie>? fieldsScmRepositories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGitReferencesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsScmGitReferences"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ScmGitReferencesResponse>> ScmRepositoriesGitReferencesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmGitReference>? fieldsScmGitReferences = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGitReferencesGetToManyRelatedFieldsScmRepositorie>? fieldsScmRepositories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmRepositoriesGitReferencesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}