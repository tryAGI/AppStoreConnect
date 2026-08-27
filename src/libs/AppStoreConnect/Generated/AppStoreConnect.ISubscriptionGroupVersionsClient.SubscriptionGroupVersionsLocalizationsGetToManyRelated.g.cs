#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionGroupVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionGroupLocalizationsV2Response> SubscriptionGroupVersionsLocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsLocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSubscriptionGroupLocalizations"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionGroupLocalizationsV2Response>> SubscriptionGroupVersionsLocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupLocalization>? fieldsSubscriptionGroupLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsLocalizationsGetToManyRelatedFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionGroupVersionsLocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}