#nullable enable

namespace AppStoreConnect
{
    public partial interface IPromotedPurchasesClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsPromotedPurchases"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.PromotedPurchaseResponse> PromotedPurchasesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsPromotedPurchases"></param>
        /// <param name="fieldsInAppPurchases"></param>
        /// <param name="fieldsSubscriptions"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.PromotedPurchaseResponse>> PromotedPurchasesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsPromotedPurchase>? fieldsPromotedPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsInAppPurchase>? fieldsInAppPurchases = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceFieldsSubscription>? fieldsSubscriptions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.PromotedPurchasesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}