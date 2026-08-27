#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppInfos"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsAgeRatingDeclarations"></param>
        /// <param name="fieldsAppInfoLocalizations"></param>
        /// <param name="fieldsAppCategories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppInfoLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppInfosResponse> AppsAppInfosGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfo>? fieldsAppInfos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration>? fieldsAgeRatingDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization>? fieldsAppInfoLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppCategorie>? fieldsAppCategories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedIncludeItem>? include = default,
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
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitAppInfoLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppInfosResponse>> AppsAppInfosGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfo>? fieldsAppInfos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAgeRatingDeclaration>? fieldsAgeRatingDeclarations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppInfoLocalization>? fieldsAppInfoLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedFieldsAppCategorie>? fieldsAppCategories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsAppInfosGetToManyRelatedIncludeItem>? include = default,
            int? limitAppInfoLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}