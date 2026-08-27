#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppInfosClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppInfos"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAgeRatingDeclarations"></param>
        /// <param name="fieldsAppInfoLocalizations"></param>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="include"></param>
        /// <param name="limitAppInfoLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppInfoResponse> AppInfosGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo>? fieldsAppInfos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration>? fieldsAgeRatingDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization>? fieldsAppInfoLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie>? fieldsAppCategories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceIncludeItem>? include = default,
            int? limitAppInfoLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppInfos"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAgeRatingDeclarations"></param>
        /// <param name="fieldsAppInfoLocalizations"></param>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="include"></param>
        /// <param name="limitAppInfoLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppInfoResponse>> AppInfosGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfo>? fieldsAppInfos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAgeRatingDeclaration>? fieldsAgeRatingDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppInfoLocalization>? fieldsAppInfoLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceFieldsAppCategorie>? fieldsAppCategories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosGetInstanceIncludeItem>? include = default,
            int? limitAppInfoLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}