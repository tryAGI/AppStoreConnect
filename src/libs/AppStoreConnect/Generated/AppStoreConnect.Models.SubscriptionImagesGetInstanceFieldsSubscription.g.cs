
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionImagesGetInstanceFieldsSubscription
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
    public static class SubscriptionImagesGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImagesGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionImagesGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionImagesGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionImagesGetInstanceFieldsSubscription.Group => "group",
                SubscriptionImagesGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionImagesGetInstanceFieldsSubscription.Images => "images",
                SubscriptionImagesGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionImagesGetInstanceFieldsSubscription.Name => "name",
                SubscriptionImagesGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionImagesGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionImagesGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionImagesGetInstanceFieldsSubscription.Prices => "prices",
                SubscriptionImagesGetInstanceFieldsSubscription.ProductId => "productId",
                SubscriptionImagesGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionImagesGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionImagesGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionImagesGetInstanceFieldsSubscription.State => "state",
                SubscriptionImagesGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionImagesGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionImagesGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionImagesGetInstanceFieldsSubscription.Versions => "versions",
                SubscriptionImagesGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImagesGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionImagesGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionImagesGetInstanceFieldsSubscription.FamilySharable,
                "group" => SubscriptionImagesGetInstanceFieldsSubscription.Group,
                "groupLevel" => SubscriptionImagesGetInstanceFieldsSubscription.GroupLevel,
                "images" => SubscriptionImagesGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionImagesGetInstanceFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionImagesGetInstanceFieldsSubscription.Name,
                "offerCodes" => SubscriptionImagesGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionImagesGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionImagesGetInstanceFieldsSubscription.PricePoints,
                "prices" => SubscriptionImagesGetInstanceFieldsSubscription.Prices,
                "productId" => SubscriptionImagesGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionImagesGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionImagesGetInstanceFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionImagesGetInstanceFieldsSubscription.ReviewNote,
                "state" => SubscriptionImagesGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionImagesGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionImagesGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionImagesGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionImagesGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionImagesGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}