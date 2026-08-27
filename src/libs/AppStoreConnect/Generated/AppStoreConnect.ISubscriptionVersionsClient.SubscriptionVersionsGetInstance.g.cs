#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionVersionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSubscriptionVersions"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionImages"></param>
        /// <param name="fieldsSubscriptionLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionVersionResponse> SubscriptionVersionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionImage>? fieldsSubscriptionImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceIncludeItem>? include = default,
            int? limitImages = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsSubscriptionVersions"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="fieldsSubscriptionImages"></param>
        /// <param name="fieldsSubscriptionLocalizations"></param>
        /// <param name="include"></param>
        /// <param name="limitImages"></param>
        /// <param name="limitLocalizations"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionVersionResponse>> SubscriptionVersionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionImage>? fieldsSubscriptionImages = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceFieldsSubscriptionLocalization>? fieldsSubscriptionLocalizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionVersionsGetInstanceIncludeItem>? include = default,
            int? limitImages = default,
            int? limitLocalizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}