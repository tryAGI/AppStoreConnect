#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionLocalizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionLocalizations"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionLocalizationResponse> SubscriptionLocalizationsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionLocalizationsGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionLocalizations"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionLocalizationResponse>> SubscriptionLocalizationsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionLocalizationsGetInstanceFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionLocalizationsGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionLocalizationsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}