#nullable enable

namespace AppStoreConnect
{
    public partial interface ICiWorkflowsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsCiWorkflows"></param>
        /// <param name="fieldsCiProducts"></param>
        /// <param name="fieldsScmRepositories"></param>
        /// <param name="fieldsCiXcodeVersions"></param>
        /// <param name="fieldsCiMacOsVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CiWorkflowResponse> CiWorkflowsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow>? fieldsCiWorkflows = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem>? include = default,
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
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CiWorkflowResponse>> CiWorkflowsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiWorkflow>? fieldsCiWorkflows = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiProduct>? fieldsCiProducts = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsScmRepositorie>? fieldsScmRepositories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiXcodeVersion>? fieldsCiXcodeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceFieldsCiMacOsVersion>? fieldsCiMacOsVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CiWorkflowsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}