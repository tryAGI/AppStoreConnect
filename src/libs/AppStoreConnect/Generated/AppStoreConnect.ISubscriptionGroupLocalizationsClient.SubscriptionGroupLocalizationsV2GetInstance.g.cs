#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionGroupLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionGroupLocalizationV2Response> SubscriptionGroupLocalizationsV2GetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupLocalizationsV2GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionGroupLocalizationV2Response>> SubscriptionGroupLocalizationsV2GetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupLocalizationsV2GetInstanceFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupLocalizationsV2GetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}