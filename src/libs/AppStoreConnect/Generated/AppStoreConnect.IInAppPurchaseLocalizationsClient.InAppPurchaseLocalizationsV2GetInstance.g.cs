#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseLocalizationsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseLocalizationV2Response> InAppPurchaseLocalizationsV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsV2GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseLocalizationV2Response>> InAppPurchaseLocalizationsV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsV2GetInstanceFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseLocalizationsV2GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}