#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="filterRating"></param>
        /// <param name="filterReviewTerritory"></param>
        /// <param name="existsPublishedResponse"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsCustomerReviews"></param>
        /// <param name="fieldsCustomerReviewResponses"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CustomerReviewsResponse> AppsCustomerReviewsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem>? filterTerritory = default,
            global::System.Collections.Generic.IList<string>? filterRating = default,
            global::System.Collections.Generic.IList<string>? filterReviewTerritory = default,
            bool? existsPublishedResponse = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview>? fieldsCustomerReviews = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse>? fieldsCustomerReviewResponses = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterTerritory"></param>
        /// <param name="filterRating"></param>
        /// <param name="filterReviewTerritory"></param>
        /// <param name="existsPublishedResponse"></param>
        /// <param name="sort"></param>
        /// <param name="fieldsCustomerReviews"></param>
        /// <param name="fieldsCustomerReviewResponses"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CustomerReviewsResponse>> AppsCustomerReviewsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFilterTerritoryItem>? filterTerritory = default,
            global::System.Collections.Generic.IList<string>? filterRating = default,
            global::System.Collections.Generic.IList<string>? filterReviewTerritory = default,
            bool? existsPublishedResponse = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedSortItem>? sort = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReview>? fieldsCustomerReviews = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsCustomerReviewResponse>? fieldsCustomerReviewResponses = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}