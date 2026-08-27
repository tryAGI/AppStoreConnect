#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionGroupVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionGroupVersionResponse> SubscriptionGroupVersionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionGroupVersionResponse>> SubscriptionGroupVersionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsGetInstanceIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}