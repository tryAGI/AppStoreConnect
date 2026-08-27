#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterReferenceName"></param>
        /// <param name="filterSubscriptionsState"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitSubscriptions"></param>
        /// <param name="limitSubscriptionGroupLocalizations"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionGroupsResponse> AppsSubscriptionGroupsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterReferenceName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem>? filterSubscriptionsState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedIncludeItem>? include = default,
            int? limitSubscriptions = default,
            int? limitSubscriptionGroupLocalizations = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterReferenceName"></param>
        /// <param name="filterSubscriptionsState"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitSubscriptions"></param>
        /// <param name="limitSubscriptionGroupLocalizations"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionGroupsResponse>> AppsSubscriptionGroupsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterReferenceName = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedFilterSubscriptionsStateItem>? filterSubscriptionsState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsSubscriptionGroupsGetToManyRelatedIncludeItem>? include = default,
            int? limitSubscriptions = default,
            int? limitSubscriptionGroupLocalizations = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}