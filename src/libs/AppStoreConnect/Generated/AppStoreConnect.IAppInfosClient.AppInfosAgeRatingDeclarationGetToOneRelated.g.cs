#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppInfosClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAgeRatingDeclarations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AgeRatingDeclarationResponse> AppInfosAgeRatingDeclarationGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration>? fieldsAgeRatingDeclarations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAgeRatingDeclarations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AgeRatingDeclarationResponse>> AppInfosAgeRatingDeclarationGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAgeRatingDeclarationGetToOneRelatedFieldsAgeRatingDeclaration>? fieldsAgeRatingDeclarations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}