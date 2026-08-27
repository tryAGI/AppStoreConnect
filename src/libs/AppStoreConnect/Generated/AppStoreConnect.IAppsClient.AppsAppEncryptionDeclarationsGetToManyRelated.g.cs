#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterBuilds"></param>
        /// <param name="fieldsAppEncryptionDeclarations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsAppEncryptionDeclarationDocuments"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppEncryptionDeclarationsResponse> AppsAppEncryptionDeclarationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument>? fieldsAppEncryptionDeclarationDocuments = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterBuilds"></param>
        /// <param name="fieldsAppEncryptionDeclarations"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsBuilds"></param>
        /// <param name="fieldsAppEncryptionDeclarationDocuments"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitBuilds"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppEncryptionDeclarationsResponse>> AppsAppEncryptionDeclarationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<string>? filterBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclaration>? fieldsAppEncryptionDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsBuild>? fieldsBuilds = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedFieldsAppEncryptionDeclarationDocument>? fieldsAppEncryptionDeclarationDocuments = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppEncryptionDeclarationsGetToManyRelatedIncludeItem>? include = default,
            int? limitBuilds = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}