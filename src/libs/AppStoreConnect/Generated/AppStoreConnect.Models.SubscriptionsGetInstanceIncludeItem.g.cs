
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsGetInstanceIncludeItem
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
    public static class SubscriptionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionsGetInstanceIncludeItem.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsGetInstanceIncludeItem.Group => "group",
                SubscriptionsGetInstanceIncludeItem.Images => "images",
                SubscriptionsGetInstanceIncludeItem.IntroductoryOffers => "introductoryOffers",
                SubscriptionsGetInstanceIncludeItem.OfferCodes => "offerCodes",
                SubscriptionsGetInstanceIncludeItem.PlanAvailabilities => "planAvailabilities",
                SubscriptionsGetInstanceIncludeItem.Prices => "prices",
                SubscriptionsGetInstanceIncludeItem.PromotedPurchase => "promotedPurchase",
                SubscriptionsGetInstanceIncludeItem.PromotionalOffers => "promotionalOffers",
                SubscriptionsGetInstanceIncludeItem.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsGetInstanceIncludeItem.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsGetInstanceIncludeItem.Versions => "versions",
                SubscriptionsGetInstanceIncludeItem.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsGetInstanceIncludeItem.AppStoreReviewScreenshot,
                "group" => SubscriptionsGetInstanceIncludeItem.Group,
                "images" => SubscriptionsGetInstanceIncludeItem.Images,
                "introductoryOffers" => SubscriptionsGetInstanceIncludeItem.IntroductoryOffers,
                "offerCodes" => SubscriptionsGetInstanceIncludeItem.OfferCodes,
                "planAvailabilities" => SubscriptionsGetInstanceIncludeItem.PlanAvailabilities,
                "prices" => SubscriptionsGetInstanceIncludeItem.Prices,
                "promotedPurchase" => SubscriptionsGetInstanceIncludeItem.PromotedPurchase,
                "promotionalOffers" => SubscriptionsGetInstanceIncludeItem.PromotionalOffers,
                "subscriptionAvailability" => SubscriptionsGetInstanceIncludeItem.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsGetInstanceIncludeItem.SubscriptionLocalizations,
                "versions" => SubscriptionsGetInstanceIncludeItem.Versions,
                "winBackOffers" => SubscriptionsGetInstanceIncludeItem.WinBackOffers,
                _ => null,
            };
        }
    }
}