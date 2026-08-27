#nullable enable

namespace AppStoreConnect
{
    public partial interface IReviewSubmissionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterState"></param>
        /// <param name="filterApp"></param>
        /// <param name="fieldsReviewSubmissions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsReviewSubmissionItems"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitItems"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ReviewSubmissionsResponse> ReviewSubmissionsGetCollectionAsync(
            global::System.Collections.Generic.IList<string> filterApp,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission>? fieldsReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem>? fieldsReviewSubmissionItems = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor>? fieldsActors = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem>? include = default,
            int? limitItems = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterState"></param>
        /// <param name="filterApp"></param>
        /// <param name="fieldsReviewSubmissions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsReviewSubmissionItems"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitItems"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ReviewSubmissionsResponse>> ReviewSubmissionsGetCollectionAsResponseAsync(
            global::System.Collections.Generic.IList<string> filterApp,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmission>? fieldsReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem>? fieldsReviewSubmissionItems = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionFieldsActor>? fieldsActors = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetCollectionIncludeItem>? include = default,
            int? limitItems = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}