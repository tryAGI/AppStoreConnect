#nullable enable

namespace AppStoreConnect
{
    public partial interface IRetentionOffersClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsRetentionOfferPrices"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.RetentionOfferPricesResponse> RetentionOffersPricesGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionOffersPricesGetToManyRelatedFieldsRetentionOfferPrice>? fieldsRetentionOfferPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionOffersPricesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionOffersPricesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsRetentionOfferPrices"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.RetentionOfferPricesResponse>> RetentionOffersPricesGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionOffersPricesGetToManyRelatedFieldsRetentionOfferPrice>? fieldsRetentionOfferPrices = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionOffersPricesGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionOffersPricesGetToManyRelatedFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.RetentionOffersPricesGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}