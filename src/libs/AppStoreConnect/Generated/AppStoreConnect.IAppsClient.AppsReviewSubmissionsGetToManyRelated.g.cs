#nullable enable

namespace AppStoreConnect
{
    public partial interface IAppsClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterState"></param>
        /// <param name="fieldsReviewSubmissions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsReviewSubmissionItems"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitItems"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ReviewSubmissionsResponse> AppsReviewSubmissionsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission>? fieldsReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem>? fieldsReviewSubmissionItems = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsActor>? fieldsActors = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedIncludeItem>? include = default,
            int? limitItems = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///
        /// </summary>
        /// <param name="filterPlatform"></param>
        /// <param name="filterState"></param>
        /// <param name="fieldsReviewSubmissions"></param>
        /// <param name="fieldsApps"></param>
        /// <param name="fieldsReviewSubmissionItems"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsActors"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="limitItems"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ReviewSubmissionsResponse>> AppsReviewSubmissionsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterPlatformItem>? filterPlatform = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFilterStateItem>? filterState = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmission>? fieldsReviewSubmissions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsApp>? fieldsApps = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem>? fieldsReviewSubmissionItems = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedFieldsActor>? fieldsActors = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.AppsReviewSubmissionsGetToManyRelatedIncludeItem>? include = default,
            int? limitItems = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}