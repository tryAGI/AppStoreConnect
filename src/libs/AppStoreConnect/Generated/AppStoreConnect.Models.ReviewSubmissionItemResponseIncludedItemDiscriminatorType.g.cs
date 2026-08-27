
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPageVersions,
        /// <summary>
        /// 
        /// </summary>
        AppEvents,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperiments,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
        /// <summary>
        /// 
        /// </summary>
        BackgroundAssetVersions,
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementVersions,
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivityVersions,
        /// <summary>
        /// 
        /// </summary>
        GameCenterChallengeVersions,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetVersions,
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardVersions,
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseVersions,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroupVersions,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppEvents => "appEvents",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.BackgroundAssetVersions => "backgroundAssetVersions",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterActivityVersions => "gameCenterActivityVersions",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions => "gameCenterLeaderboardSetVersions",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions => "gameCenterLeaderboardVersions",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.InAppPurchaseVersions => "inAppPurchaseVersions",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                ReviewSubmissionItemResponseIncludedItemDiscriminatorType.SubscriptionVersions => "subscriptionVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions,
                "appEvents" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppEvents,
                "appStoreVersionExperiments" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments,
                "appStoreVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "backgroundAssetVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.BackgroundAssetVersions,
                "gameCenterAchievementVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions,
                "gameCenterActivityVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterActivityVersions,
                "gameCenterChallengeVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions,
                "gameCenterLeaderboardSetVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions,
                "gameCenterLeaderboardVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions,
                "inAppPurchaseVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.InAppPurchaseVersions,
                "subscriptionGroupVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.SubscriptionGroupVersions,
                "subscriptionVersions" => ReviewSubmissionItemResponseIncludedItemDiscriminatorType.SubscriptionVersions,
                _ => null,
            };
        }
    }
}