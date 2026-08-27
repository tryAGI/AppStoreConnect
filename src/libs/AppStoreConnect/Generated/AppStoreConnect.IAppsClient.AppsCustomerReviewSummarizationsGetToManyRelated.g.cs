#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsCustomerReviewSummarizations"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.CustomerReviewSummarizationsResponse> AppsCustomerReviewSummarizationsGetToManyRelatedAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem> filterPlatform,
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization>? fieldsCustomerReviewSummarizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterTerritory"></param>
        /// <param name="fieldsCustomerReviewSummarizations"></param>
        /// <param name="fieldsTerritories"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.CustomerReviewSummarizationsResponse>> AppsCustomerReviewSummarizationsGetToManyRelatedAsResponseAsync(
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFilterPlatformItem> filterPlatform,
            string id,
            global::System.Collections.Generic.IList<string>? filterTerritory = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsCustomerReviewSummarization>? fieldsCustomerReviewSummarizations = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedFieldsTerritorie>? fieldsTerritories = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsCustomerReviewSummarizationsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}