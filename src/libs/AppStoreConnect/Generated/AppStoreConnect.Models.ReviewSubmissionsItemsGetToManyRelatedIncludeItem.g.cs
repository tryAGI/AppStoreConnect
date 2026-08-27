
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedIncludeItem
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
        SubscriptionGroupVersion,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionsItemsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.AppCustomProductPageVersion => "appCustomProductPageVersion",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.AppEvent => "appEvent",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.AppStoreVersionExperiment => "appStoreVersionExperiment",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.BackgroundAssetVersion => "backgroundAssetVersion",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.GameCenterAchievementVersion => "gameCenterAchievementVersion",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.GameCenterActivityVersion => "gameCenterActivityVersion",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.GameCenterChallengeVersion => "gameCenterChallengeVersion",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.GameCenterLeaderboardSetVersion => "gameCenterLeaderboardSetVersion",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.GameCenterLeaderboardVersion => "gameCenterLeaderboardVersion",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.InAppPurchaseVersion => "inAppPurchaseVersion",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.SubscriptionGroupVersion => "subscriptionGroupVersion",
                ReviewSubmissionsItemsGetToManyRelatedIncludeItem.SubscriptionVersion => "subscriptionVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.AppCustomProductPageVersion,
                "appEvent" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.AppEvent,
                "appStoreVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.AppStoreVersion,
                "appStoreVersionExperiment" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.AppStoreVersionExperiment,
                "appStoreVersionExperimentV2" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.AppStoreVersionExperimentV2,
                "backgroundAssetVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.BackgroundAssetVersion,
                "gameCenterAchievementVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.GameCenterAchievementVersion,
                "gameCenterActivityVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.GameCenterActivityVersion,
                "gameCenterChallengeVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.GameCenterChallengeVersion,
                "gameCenterLeaderboardSetVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.GameCenterLeaderboardSetVersion,
                "gameCenterLeaderboardVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.GameCenterLeaderboardVersion,
                "inAppPurchaseVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.InAppPurchaseVersion,
                "subscriptionGroupVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.SubscriptionGroupVersion,
                "subscriptionVersion" => ReviewSubmissionsItemsGetToManyRelatedIncludeItem.SubscriptionVersion,
                _ => null,
            };
        }
    }
}