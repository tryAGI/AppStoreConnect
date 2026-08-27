#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiProductsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiWorkflows"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="fieldsCiXcodeVersions"></param>
        /// <param name="fieldsCiMacOsVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiWorkflowsResponse> CiProductsWorkflowsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow>? fieldsCiWorkflows = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCiWorkflows"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="fieldsCiXcodeVersions"></param>
        /// <param name="fieldsCiMacOsVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiWorkflowsResponse>> CiProductsWorkflowsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiWorkflow>? fieldsCiWorkflows = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiProductsWorkflowsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}