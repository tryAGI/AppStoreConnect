
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem
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
    public static class AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem value)
        {
            return value switch
            {
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.AppEvent => "appEvent",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersion => "appStoreVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersionExperiment => "appStoreVersionExperiment",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.BackgroundAssetVersion => "backgroundAssetVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterAchievementVersion => "gameCenterAchievementVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterActivityVersion => "gameCenterActivityVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterChallengeVersion => "gameCenterChallengeVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterLeaderboardSetVersion => "gameCenterLeaderboardSetVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterLeaderboardVersion => "gameCenterLeaderboardVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.InAppPurchaseVersion => "inAppPurchaseVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.State => "state",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.SubscriptionGroupVersion => "subscriptionGroupVersion",
                AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.SubscriptionVersion => "subscriptionVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.AppCustomProductPageVersion,
                "appEvent" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.AppEvent,
                "appStoreVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersion,
                "appStoreVersionExperiment" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersionExperiment,
                "appStoreVersionExperimentV2" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.AppStoreVersionExperimentV2,
                "backgroundAssetVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.BackgroundAssetVersion,
                "gameCenterAchievementVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterAchievementVersion,
                "gameCenterActivityVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterActivityVersion,
                "gameCenterChallengeVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterChallengeVersion,
                "gameCenterLeaderboardSetVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterLeaderboardSetVersion,
                "gameCenterLeaderboardVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.GameCenterLeaderboardVersion,
                "inAppPurchaseVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.InAppPurchaseVersion,
                "state" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.State,
                "subscriptionGroupVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.SubscriptionGroupVersion,
                "subscriptionVersion" => AppsReviewSubmissionsGetToManyRelatedFieldsReviewSubmissionItem.SubscriptionVersion,
                _ => null,
            };
        }
    }
}