
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreReviewScreenshot,
        /// <summary>
        /// 
        /// </summary>
        Group,
        /// <summary>
        /// 
        /// </summary>
        Images,
        /// <summary>
        /// 
        /// </summary>
        IntroductoryOffers,
        /// <summary>
        /// 
        /// </summary>
        OfferCodes,
        /// <summary>
        /// 
        /// </summary>
        PlanAvailabilities,
        /// <summary>
        /// 
        /// </summary>
        Prices,
        /// <summary>
        /// 
        /// </summary>
        PromotedPurchase,
        /// <summary>
        /// 
        /// </summary>
        PromotionalOffers,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionAvailability,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionLocalizations,
        /// <summary>
        /// 
        /// </summary>
        Versions,
        /// <summary>
        /// 
        /// </summary>
        WinBackOffers,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.Group => "group",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.Images => "images",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.IntroductoryOffers => "introductoryOffers",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.OfferCodes => "offerCodes",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.PlanAvailabilities => "planAvailabilities",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.Prices => "prices",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.PromotedPurchase => "promotedPurchase",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.PromotionalOffers => "promotionalOffers",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.Versions => "versions",
                SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.AppStoreReviewScreenshot,
                "group" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.Group,
                "images" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.Images,
                "introductoryOffers" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.IntroductoryOffers,
                "offerCodes" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.OfferCodes,
                "planAvailabilities" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.PlanAvailabilities,
                "prices" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.Prices,
                "promotedPurchase" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.PromotedPurchase,
                "promotionalOffers" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.PromotionalOffers,
                "subscriptionAvailability" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.SubscriptionLocalizations,
                "versions" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.Versions,
                "winBackOffers" => SubscriptionGroupsSubscriptionsGetToManyRelatedIncludeItem.WinBackOffers,
                _ => null,
            };
        }
    }
}