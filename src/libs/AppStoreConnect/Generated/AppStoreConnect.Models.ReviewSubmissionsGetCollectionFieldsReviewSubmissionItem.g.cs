
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPageVersion,
        /// <summary>
        /// 
        /// </summary>
        AppEvent,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperiment,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentV2,
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersion,
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementVersion,
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivityVersion,
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallengeVersion,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetVersion,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardVersion,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseVersion,
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroupVersion,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionsGetCollectionFieldsReviewSubmissionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem value)
        {
            return value switch
            {
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.AppCustomProductPageVersion => "appCustomProductPageVersion",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.AppEvent => "appEvent",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.AppStoreVersion => "appStoreVersion",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.AppStoreVersionExperiment => "appStoreVersionExperiment",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.BackgroundAssetVersion => "backgroundAssetVersion",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.GameCenterAchievementVersion => "gameCenterAchievementVersion",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.GameCenterActivityVersion => "gameCenterActivityVersion",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.GameCenterChallengeVersion => "gameCenterChallengeVersion",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.GameCenterLeaderboardSetVersion => "gameCenterLeaderboardSetVersion",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.GameCenterLeaderboardVersion => "gameCenterLeaderboardVersion",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.InAppPurchaseVersion => "inAppPurchaseVersion",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.State => "state",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.SubscriptionGroupVersion => "subscriptionGroupVersion",
                ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.SubscriptionVersion => "subscriptionVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.AppCustomProductPageVersion,
                "appEvent" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.AppEvent,
                "appStoreVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.AppStoreVersion,
                "appStoreVersionExperiment" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.AppStoreVersionExperiment,
                "appStoreVersionExperimentV2" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.AppStoreVersionExperimentV2,
                "backgroundAssetVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.BackgroundAssetVersion,
                "gameCenterAchievementVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.GameCenterAchievementVersion,
                "gameCenterActivityVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.GameCenterActivityVersion,
                "gameCenterChallengeVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.GameCenterChallengeVersion,
                "gameCenterLeaderboardSetVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.GameCenterLeaderboardSetVersion,
                "gameCenterLeaderboardVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.GameCenterLeaderboardVersion,
                "inAppPurchaseVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.InAppPurchaseVersion,
                "state" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.State,
                "subscriptionGroupVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.SubscriptionGroupVersion,
                "subscriptionVersion" => ReviewSubmissionsGetCollectionFieldsReviewSubmissionItem.SubscriptionVersion,
                _ => null,
            };
        }
    }
}