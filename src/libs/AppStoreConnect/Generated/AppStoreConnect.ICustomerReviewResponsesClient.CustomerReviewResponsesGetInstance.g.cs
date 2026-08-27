#nullable enable

namespace AppStoreConnect
{
    public partial interface ICustomerReviewResponsesClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCustomerReviewResponses"></param>
        /// <param name="fieldsCustomerReviews"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CustomerReviewResponseV1Response> CustomerReviewResponsesGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse>? fieldsCustomerReviewResponses = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview>? fieldsCustomerReviews = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsCustomerReviewResponses"></param>
        /// <param name="fieldsCustomerReviews"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CustomerReviewResponseV1Response>> CustomerReviewResponsesGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReviewResponse>? fieldsCustomerReviewResponses = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceFieldsCustomerReview>? fieldsCustomerReviews = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.CustomerReviewResponsesGetInstanceIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}