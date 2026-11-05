#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionMessages"></param>
        /// <param name="fieldsRetentionMessageVersions"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="include"></param>
        /// <param name="limitVersions"></param>
        /// <param name="limitSubscriptions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.RetentionMessageResponse> SubscriptionsRetentionMessageGetToOneRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage>? fieldsRetentionMessages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion>? fieldsRetentionMessageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionMessageGetToOneRelatedIncludeItem>? include = default,
            int? limitVersions = default,
            int? limitSubscriptions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionMessages"></param>
        /// <param name="fieldsRetentionMessageVersions"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="include"></param>
        /// <param name="limitVersions"></param>
        /// <param name="limitSubscriptions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.RetentionMessageResponse>> SubscriptionsRetentionMessageGetToOneRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessage>? fieldsRetentionMessages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionMessageGetToOneRelatedFieldsRetentionMessageVersion>? fieldsRetentionMessageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionsRetentionMessageGetToOneRelatedIncludeItem>? include = default,
            int? limitVersions = default,
            int? limitSubscriptions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}