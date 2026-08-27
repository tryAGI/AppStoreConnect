
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionLocalizationsGetInstanceFieldsSubscription
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
    public static class SubscriptionLocalizationsGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationsGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionLocalizationsGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.Group => "group",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.Images => "images",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.Name => "name",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.Prices => "prices",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.ProductId => "productId",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.State => "state",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.Versions => "versions",
                SubscriptionLocalizationsGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationsGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionLocalizationsGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionLocalizationsGetInstanceFieldsSubscription.FamilySharable,
                "group" => SubscriptionLocalizationsGetInstanceFieldsSubscription.Group,
                "groupLevel" => SubscriptionLocalizationsGetInstanceFieldsSubscription.GroupLevel,
                "images" => SubscriptionLocalizationsGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionLocalizationsGetInstanceFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionLocalizationsGetInstanceFieldsSubscription.Name,
                "offerCodes" => SubscriptionLocalizationsGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionLocalizationsGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionLocalizationsGetInstanceFieldsSubscription.PricePoints,
                "prices" => SubscriptionLocalizationsGetInstanceFieldsSubscription.Prices,
                "productId" => SubscriptionLocalizationsGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionLocalizationsGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionLocalizationsGetInstanceFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionLocalizationsGetInstanceFieldsSubscription.ReviewNote,
                "state" => SubscriptionLocalizationsGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionLocalizationsGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionLocalizationsGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionLocalizationsGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionLocalizationsGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionLocalizationsGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}