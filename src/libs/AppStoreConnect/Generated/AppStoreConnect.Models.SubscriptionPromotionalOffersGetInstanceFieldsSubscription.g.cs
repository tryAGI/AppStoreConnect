
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPromotionalOffersGetInstanceFieldsSubscription
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewScreenshot,
        /// <summary>
        ///
        /// </summary>
        FamilySharable,
        /// <summary>
        ///
        /// </summary>
        Group,
        /// <summary>
        ///
        /// </summary>
        GroupLevel,
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
        Name,
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
        PricePoints,
        /// <summary>
        ///
        /// </summary>
        Prices,
        /// <summary>
        ///
        /// </summary>
        ProductId,
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
        ReviewNote,
        /// <summary>
        ///
        /// </summary>
        State,
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
        SubscriptionPeriod,
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
    public static class SubscriptionPromotionalOffersGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPromotionalOffersGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.Group => "group",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.Images => "images",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.Name => "name",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.Prices => "prices",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.ProductId => "productId",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.State => "state",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.Versions => "versions",
                SubscriptionPromotionalOffersGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPromotionalOffersGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.FamilySharable,
                "group" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.Group,
                "groupLevel" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.GroupLevel,
                "images" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.Name,
                "offerCodes" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.PricePoints,
                "prices" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.Prices,
                "productId" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.ReviewNote,
                "state" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionPromotionalOffersGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}