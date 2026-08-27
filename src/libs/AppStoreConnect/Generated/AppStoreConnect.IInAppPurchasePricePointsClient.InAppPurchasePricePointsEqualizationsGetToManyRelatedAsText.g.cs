#nullable enable

namespace AppStoreConnect
{
    public partial interface IInAppPurchasePricePointsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="filterInAppPurchaseV2"></param>
        /// <param name="fieldsInAppPurchasePricePoints"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> InAppPurchasePricePointsEqualizationsGetToManyRelatedAsTextAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<string>? filterInAppPurchaseV2 = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint>? fieldsInAppPurchasePricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePricePointsEqualizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="filterInAppPurchaseV2"></param>
        /// <param name="fieldsInAppPurchasePricePoints"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<string>> InAppPurchasePricePointsEqualizationsGetToManyRelatedAsTextAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<string>? filterInAppPurchaseV2 = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsInAppPurchasePricePoint>? fieldsInAppPurchasePricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePricePointsEqualizationsGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.InAppPurchasePricePointsEqualizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}