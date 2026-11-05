#nullable enable

namespace AppStoreConnect
{
    public partial interface IRetentionMessagesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionMessages"></param>
        /// <param name="fieldsRetentionMessageVersions"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="include"></param>
        /// <param name="limitSubscriptions"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.RetentionMessageResponse> RetentionMessagesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesGetInstanceFieldsRetentionMessage>? fieldsRetentionMessages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesGetInstanceFieldsRetentionMessageVersion>? fieldsRetentionMessageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesGetInstanceIncludeItem>? include = default,
            int? limitSubscriptions = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsRetentionMessages"></param>
        /// <param name="fieldsRetentionMessageVersions"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="include"></param>
        /// <param name="limitSubscriptions"></param>
        /// <param name="limitVersions"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.RetentionMessageResponse>> RetentionMessagesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesGetInstanceFieldsRetentionMessage>? fieldsRetentionMessages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesGetInstanceFieldsRetentionMessageVersion>? fieldsRetentionMessageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionMessagesGetInstanceIncludeItem>? include = default,
            int? limitSubscriptions = default,
            int? limitVersions = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}