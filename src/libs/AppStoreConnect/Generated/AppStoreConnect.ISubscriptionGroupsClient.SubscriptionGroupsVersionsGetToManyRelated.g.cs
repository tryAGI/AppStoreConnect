#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionGroupsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterState"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionGroupVersionsResponse> SubscriptionGroupsVersionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterState"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="fieldsSubscriptionGroups"></param>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionGroupVersionsResponse>> SubscriptionGroupsVersionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroup>? fieldsSubscriptionGroups = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupsVersionsGetToManyRelatedIncludeItem>? include = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}