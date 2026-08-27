#nullable enable

namespace AppStoreConnect
{
    public partial interface ICustomerReviewsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsCustomerReviews"></param>
        /// <param name="fieldsCustomerReviewResponses"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CustomerReviewResponse> CustomerReviewsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReview>? fieldsCustomerReviews = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReviewResponse>? fieldsCustomerReviewResponses = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsCustomerReviews"></param>
        /// <param name="fieldsCustomerReviewResponses"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CustomerReviewResponse>> CustomerReviewsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReview>? fieldsCustomerReviews = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsCustomerReviewResponse>? fieldsCustomerReviewResponses = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceFieldsTerritorie>? fieldsTerritories = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewsGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}