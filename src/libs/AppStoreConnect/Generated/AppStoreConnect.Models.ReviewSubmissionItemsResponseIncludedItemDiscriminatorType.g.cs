
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemsResponseIncludedItemDiscriminatorType
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
    public static class ReviewSubmissionItemsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppEvents => "appEvents",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.BackgroundAssetVersions => "backgroundAssetVersions",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterActivityVersions => "gameCenterActivityVersions",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions => "gameCenterChallengeVersions",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions => "gameCenterLeaderboardSetVersions",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions => "gameCenterLeaderboardVersions",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.InAppPurchaseVersions => "inAppPurchaseVersions",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.SubscriptionVersions => "subscriptionVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppCustomProductPageVersions,
                "appEvents" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppEvents,
                "appStoreVersionExperiments" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppStoreVersionExperiments,
                "appStoreVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "backgroundAssetVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.BackgroundAssetVersions,
                "gameCenterAchievementVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterAchievementVersions,
                "gameCenterActivityVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterActivityVersions,
                "gameCenterChallengeVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterChallengeVersions,
                "gameCenterLeaderboardSetVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardSetVersions,
                "gameCenterLeaderboardVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.GameCenterLeaderboardVersions,
                "inAppPurchaseVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.InAppPurchaseVersions,
                "subscriptionGroupVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.SubscriptionGroupVersions,
                "subscriptionVersions" => ReviewSubmissionItemsResponseIncludedItemDiscriminatorType.SubscriptionVersions,
                _ => null,
            };
        }
    }
}