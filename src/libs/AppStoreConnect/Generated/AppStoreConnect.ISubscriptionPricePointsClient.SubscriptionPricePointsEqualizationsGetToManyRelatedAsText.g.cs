#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionPricePointsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="filterSubscription"></param>
        /// <param name="filterUpfrontPricePointId"></param>
        /// <param name="filterPlanType"></param>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SubscriptionPricePointsEqualizationsGetToManyRelatedAsTextAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<string>? filterSubscription = default,
            global::System.Collections.Generic.IList<string>? filterUpfrontPricePointId = default,
            global::System.Collections.Generic.IList<string>? filterPlanType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePointsEqualizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="filterSubscription"></param>
        /// <param name="filterUpfrontPricePointId"></param>
        /// <param name="filterPlanType"></param>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<string>> SubscriptionPricePointsEqualizationsGetToManyRelatedAsTextAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<string>? filterSubscription = default,
            global::System.Collections.Generic.IList<string>? filterUpfrontPricePointId = default,
            global::System.Collections.Generic.IList<string>? filterPlanType = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePointsEqualizationsGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPricePointsEqualizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}