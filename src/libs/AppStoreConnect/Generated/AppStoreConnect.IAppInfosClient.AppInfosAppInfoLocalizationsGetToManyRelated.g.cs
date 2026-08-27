#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppInfosClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="fieldsAppInfoLocalizations"></param>
        /// <param name="fieldsAppInfos"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppInfoLocalizationsResponse> AppInfosAppInfoLocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization>? fieldsAppInfoLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo>? fieldsAppInfos = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterLocale"></param>
        /// <param name="fieldsAppInfoLocalizations"></param>
        /// <param name="fieldsAppInfos"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppInfoLocalizationsResponse>> AppInfosAppInfoLocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterLocale = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfoLocalization>? fieldsAppInfoLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedFieldsAppInfo>? fieldsAppInfos = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfosAppInfoLocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}