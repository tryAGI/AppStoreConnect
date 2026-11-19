#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionPriceTiersClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterSubscription"></param>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsSubscriptionPriceTiers"></param>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionPriceTiersResponse> SubscriptionPriceTiersGetCollectionAsync(
            global::System.Collections.Generic.IList<string> filterSubscription,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTiersGetCollectionFieldsSubscriptionPriceTier>? fieldsSubscriptionPriceTiers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTiersGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterSubscription"></param>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsSubscriptionPriceTiers"></param>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionPriceTiersResponse>> SubscriptionPriceTiersGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string> filterSubscription,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTiersGetCollectionFieldsSubscriptionPriceTier>? fieldsSubscriptionPriceTiers = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTiersGetCollectionFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTiersGetCollectionIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}