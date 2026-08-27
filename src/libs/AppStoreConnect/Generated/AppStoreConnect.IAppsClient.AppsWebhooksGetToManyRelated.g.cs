#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsWebhooks"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.WebhooksResponse> AppsWebhooksGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsWebhooksGetToManyRelatedFieldsWebhook>? fieldsWebhooks = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsWebhooksGetToManyRelatedFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsWebhooksGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsWebhooks"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.WebhooksResponse>> AppsWebhooksGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsWebhooksGetToManyRelatedFieldsWebhook>? fieldsWebhooks = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsWebhooksGetToManyRelatedFieldsApp>? fieldsApps = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsWebhooksGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}