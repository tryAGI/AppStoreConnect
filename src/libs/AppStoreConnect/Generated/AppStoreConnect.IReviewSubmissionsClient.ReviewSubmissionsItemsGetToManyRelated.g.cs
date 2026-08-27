#nullable enable

namespace AppStoreConnect
{
    public partial interface IReviewSubmissionsClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsReviewSubmissionItems"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="fieldsGameCenterAchievementVersions"></param>
        /// <param name="fieldsGameCenterActivityVersions"></param>
        /// <param name="fieldsGameCenterChallengeVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardSetVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardVersions"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="fieldsSubscriptionVersions"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.ReviewSubmissionItemsResponse> ReviewSubmissionsItemsGetToManyRelatedAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem>? fieldsReviewSubmissionItems = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion>? fieldsGameCenterAchievementVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion>? fieldsGameCenterActivityVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion>? fieldsGameCenterChallengeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion>? fieldsGameCenterLeaderboardSetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion>? fieldsGameCenterLeaderboardVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fieldsReviewSubmissionItems"></param>
        /// <param name="fieldsAppStoreVersions"></param>
        /// <param name="fieldsAppCustomProductPageVersions"></param>
        /// <param name="fieldsAppStoreVersionExperiments"></param>
        /// <param name="fieldsAppEvents"></param>
        /// <param name="fieldsBackgroundAssetVersions"></param>
        /// <param name="fieldsGameCenterAchievementVersions"></param>
        /// <param name="fieldsGameCenterActivityVersions"></param>
        /// <param name="fieldsGameCenterChallengeVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardSetVersions"></param>
        /// <param name="fieldsGameCenterLeaderboardVersions"></param>
        /// <param name="fieldsInAppPurchaseVersions"></param>
        /// <param name="fieldsSubscriptionVersions"></param>
        /// <param name="fieldsSubscriptionGroupVersions"></param>
        /// <param name="limit"></param>
        /// <param name="include"></param>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AppStoreConnect.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::AppStoreConnect.AutoSDKHttpResponse<global::AppStoreConnect.ReviewSubmissionItemsResponse>> ReviewSubmissionsItemsGetToManyRelatedAsResponseAsync(
            string id,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem>? fieldsReviewSubmissionItems = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersion>? fieldsAppStoreVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppCustomProductPageVersion>? fieldsAppCustomProductPageVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment>? fieldsAppStoreVersionExperiments = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsAppEvent>? fieldsAppEvents = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsBackgroundAssetVersion>? fieldsBackgroundAssetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterAchievementVersion>? fieldsGameCenterAchievementVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterActivityVersion>? fieldsGameCenterActivityVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterChallengeVersion>? fieldsGameCenterChallengeVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardSetVersion>? fieldsGameCenterLeaderboardSetVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsGameCenterLeaderboardVersion>? fieldsGameCenterLeaderboardVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsInAppPurchaseVersion>? fieldsInAppPurchaseVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionVersion>? fieldsSubscriptionVersions = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedFieldsSubscriptionGroupVersion>? fieldsSubscriptionGroupVersions = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::AppStoreConnect.ReviewSubmissionsItemsGetToManyRelatedIncludeItem>? include = default,
            global::AppStoreConnect.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}