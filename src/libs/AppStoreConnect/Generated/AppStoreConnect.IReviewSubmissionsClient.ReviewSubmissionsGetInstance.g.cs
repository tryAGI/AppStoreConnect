#nullable enable

namespace AppStoreConnect
{
    public partial interface IReviewSubmissionsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsReviewSubmissions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsReviewSubmissionItems"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="include"></param>
        /// <param name="limitItems"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ReviewSubmissionResponse> ReviewSubmissionsGetInstanceAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission>? fieldsReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem>? fieldsReviewSubmissionItems = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor>? fieldsActors = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem>? include = default,
            int? limitItems = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="fieldsReviewSubmissions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsReviewSubmissionItems"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="include"></param>
        /// <param name="limitItems"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ReviewSubmissionResponse>> ReviewSubmissionsGetInstanceAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmission>? fieldsReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem>? fieldsReviewSubmissionItems = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceFieldsActor>? fieldsActors = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsGetInstanceIncludeItem>? include = default,
            int? limitItems = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}