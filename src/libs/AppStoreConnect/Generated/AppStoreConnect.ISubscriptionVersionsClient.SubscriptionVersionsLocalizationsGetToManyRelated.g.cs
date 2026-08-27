#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionVersionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionLocalizations"></param>
        /// <param name="fieldsSubscriptionVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionLocalizationsV2Response> SubscriptionVersionsLocalizationsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsLocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionLocalizations"></param>
        /// <param name="fieldsSubscriptionVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionLocalizationsV2Response>> SubscriptionVersionsLocalizationsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsLocalizationsGetToManyRelatedFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsLocalizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}