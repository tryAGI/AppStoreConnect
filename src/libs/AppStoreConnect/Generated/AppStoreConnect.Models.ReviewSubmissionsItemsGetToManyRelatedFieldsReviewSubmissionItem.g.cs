
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.AppCustomProductPageVersion => "appCustomProductPageVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.AppEvent => "appEvent",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersion => "appStoreVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersionExperiment => "appStoreVersionExperiment",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.BackgroundAssetVersion => "backgroundAssetVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterAchievementVersion => "gameCenterAchievementVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterActivityVersion => "gameCenterActivityVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterChallengeVersion => "gameCenterChallengeVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterLeaderboardSetVersion => "gameCenterLeaderboardSetVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterLeaderboardVersion => "gameCenterLeaderboardVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.InAppPurchaseVersion => "inAppPurchaseVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.SubscriptionGroupVersion => "subscriptionGroupVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.SubscriptionVersion => "subscriptionVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.AppCustomProductPageVersion,
                "appEvent" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.AppEvent,
                "appStoreVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersion,
                "appStoreVersionExperiment" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersionExperiment,
                "appStoreVersionExperimentV2" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersionExperimentV2,
                "backgroundAssetVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.BackgroundAssetVersion,
                "gameCenterAchievementVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterAchievementVersion,
                "gameCenterActivityVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterActivityVersion,
                "gameCenterChallengeVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterChallengeVersion,
                "gameCenterLeaderboardSetVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterLeaderboardSetVersion,
                "gameCenterLeaderboardVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterLeaderboardVersion,
                "inAppPurchaseVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.InAppPurchaseVersion,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.State,
                "subscriptionGroupVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.SubscriptionGroupVersion,
                "subscriptionVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsReviewSubmissionItem.SubscriptionVersion,
                _ => null,
            };
        }
    }
}