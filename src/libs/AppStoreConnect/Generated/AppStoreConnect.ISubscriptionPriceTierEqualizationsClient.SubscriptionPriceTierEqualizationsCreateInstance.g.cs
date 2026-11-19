#nullable enable

namespace AppStoreConnect
{
    public partial interface ISubscriptionPriceTierEqualizationsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="include"></param>
        /// <param name="limitPriceTierPricePoints"></param>
        /// <param name="fieldsSubscriptionPriceTierEqualizations"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionPriceTierEqualizationResponse> SubscriptionPriceTierEqualizationsCreateInstanceAsync(

            global::AppStoreConnect.SubscriptionPriceTierEqualizationCreateRequest request,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceIncludeItem>? include = default,
            int? limitPriceTierPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization>? fieldsSubscriptionPriceTierEqualizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="include"></param>
        /// <param name="limitPriceTierPricePoints"></param>
        /// <param name="fieldsSubscriptionPriceTierEqualizations"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.SubscriptionPriceTierEqualizationResponse>> SubscriptionPriceTierEqualizationsCreateInstanceAsResponseAsync(

            global::AppStoreConnect.SubscriptionPriceTierEqualizationCreateRequest request,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceIncludeItem>? include = default,
            int? limitPriceTierPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization>? fieldsSubscriptionPriceTierEqualizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsSubscriptionPricePoints"></param>
        /// <param name="include"></param>
        /// <param name="limitPriceTierPricePoints"></param>
        /// <param name="fieldsSubscriptionPriceTierEqualizations"></param>
        /// <param name="data"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.SubscriptionPriceTierEqualizationResponse> SubscriptionPriceTierEqualizationsCreateInstanceAsync(
            global::AppStoreConnect.SubscriptionPriceTierEqualizationCreateRequestData data,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPricePoint>? fieldsSubscriptionPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceIncludeItem>? include = default,
            int? limitPriceTierPricePoints = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.SubscriptionPriceTierEqualizationsCreateInstanceFieldsSubscriptionPriceTierEqualization>? fieldsSubscriptionPriceTierEqualizations = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}