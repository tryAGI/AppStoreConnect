#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppEncryptionDeclarationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppEncryptionDeclarations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsAppEncryptionDeclarationDocuments"></param>
        /// <param name="include"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppEncryptionDeclarationResponse> AppEncryptionDeclarationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument>? fieldsAppEncryptionDeclarationDocuments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsAppEncryptionDeclarations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsAppEncryptionDeclarationDocuments"></param>
        /// <param name="include"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppEncryptionDeclarationResponse>> AppEncryptionDeclarationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceFieldsAppEncryptionDeclarationDocument>? fieldsAppEncryptionDeclarationDocuments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppEncryptionDeclarationsGetInstanceIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}