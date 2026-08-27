#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionGroupsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitSubscriptionGroupLocalizations"></param>
        /// <param name="limitSubscriptions"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionGroupResponse> SubscriptionGroupsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceIncludeItem>? include = default,
            int? limitSubscriptionGroupLocalizations = default,
            int? limitSubscriptions = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="include"></param>
        /// <param name="limitSubscriptionGroupLocalizations"></param>
        /// <param name="limitSubscriptions"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionGroupResponse>> SubscriptionGroupsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsGetInstanceIncludeItem>? include = default,
            int? limitSubscriptionGroupLocalizations = default,
            int? limitSubscriptions = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}