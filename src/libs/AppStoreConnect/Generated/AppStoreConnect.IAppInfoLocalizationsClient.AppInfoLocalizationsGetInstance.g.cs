#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppInfoLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppInfoLocalizations"></param>
        /// <param name="fieldsAppInfos"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AppInfoLocalizationResponse> AppInfoLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization>? fieldsAppInfoLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoLocalizationsGetInstanceFieldsAppInfo>? fieldsAppInfos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsAppInfoLocalizations"></param>
        /// <param name="fieldsAppInfos"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.AppInfoLocalizationResponse>> AppInfoLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoLocalizationsGetInstanceFieldsAppInfoLocalization>? fieldsAppInfoLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoLocalizationsGetInstanceFieldsAppInfo>? fieldsAppInfos = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppInfoLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}