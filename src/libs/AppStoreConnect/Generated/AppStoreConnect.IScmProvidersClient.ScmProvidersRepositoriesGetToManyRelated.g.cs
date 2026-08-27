#nullable enable

namespace AppStoreConnect
{
    public partial interface IScmProvidersClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterId"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="fieldsScmProviders"></param>
        /// <param name="fieldsScmGitReferences"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ScmRepositoriesResponse> ScmProvidersRepositoriesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider>? fieldsScmProviders = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference>? fieldsScmGitReferences = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterId"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="fieldsScmProviders"></param>
        /// <param name="fieldsScmGitReferences"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ScmRepositoriesResponse>> ScmProvidersRepositoriesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterId = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmProvider>? fieldsScmProviders = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedFieldsScmGitReference>? fieldsScmGitReferences = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ScmProvidersRepositoriesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}