#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchaseVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.InAppPurchaseLocalizationsV2Response> InAppPurchaseVersionsLocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsInAppPurchaseLocalizations"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.InAppPurchaseLocalizationsV2Response>> InAppPurchaseVersionsLocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseLocalization>? fieldsInAppPurchaseLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchaseVersionsLocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}