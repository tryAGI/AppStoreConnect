
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem
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
    public static class ReviewSubmissionsGetInstanceFieldsReviewSubmissionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem value)
        {
            return value switch
            {
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.AppCustomProductPageVersion => "appCustomProductPageVersion",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.AppEvent => "appEvent",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.AppStoreVersion => "appStoreVersion",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.AppStoreVersionExperiment => "appStoreVersionExperiment",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.BackgroundAssetVersion => "backgroundAssetVersion",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.GameCenterAchievementVersion => "gameCenterAchievementVersion",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.GameCenterActivityVersion => "gameCenterActivityVersion",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.GameCenterChallengeVersion => "gameCenterChallengeVersion",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.GameCenterLeaderboardSetVersion => "gameCenterLeaderboardSetVersion",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.GameCenterLeaderboardVersion => "gameCenterLeaderboardVersion",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.InAppPurchaseVersion => "inAppPurchaseVersion",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.State => "state",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.SubscriptionGroupVersion => "subscriptionGroupVersion",
                ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.SubscriptionVersion => "subscriptionVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.AppCustomProductPageVersion,
                "appEvent" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.AppEvent,
                "appStoreVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.AppStoreVersion,
                "appStoreVersionExperiment" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.AppStoreVersionExperiment,
                "appStoreVersionExperimentV2" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.AppStoreVersionExperimentV2,
                "backgroundAssetVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.BackgroundAssetVersion,
                "gameCenterAchievementVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.GameCenterAchievementVersion,
                "gameCenterActivityVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.GameCenterActivityVersion,
                "gameCenterChallengeVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.GameCenterChallengeVersion,
                "gameCenterLeaderboardSetVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.GameCenterLeaderboardSetVersion,
                "gameCenterLeaderboardVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.GameCenterLeaderboardVersion,
                "inAppPurchaseVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.InAppPurchaseVersion,
                "state" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.State,
                "subscriptionGroupVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.SubscriptionGroupVersion,
                "subscriptionVersion" => ReviewSubmissionsGetInstanceFieldsReviewSubmissionItem.SubscriptionVersion,
                _ => null,
            };
        }
    }
}