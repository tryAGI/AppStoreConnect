
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodesGetInstanceFieldsSubscription
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
    public static class SubscriptionOfferCodesGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionOfferCodesGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.Group => "group",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.Images => "images",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.Name => "name",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.Prices => "prices",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.ProductId => "productId",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.State => "state",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.Versions => "versions",
                SubscriptionOfferCodesGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionOfferCodesGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionOfferCodesGetInstanceFieldsSubscription.FamilySharable,
                "group" => SubscriptionOfferCodesGetInstanceFieldsSubscription.Group,
                "groupLevel" => SubscriptionOfferCodesGetInstanceFieldsSubscription.GroupLevel,
                "images" => SubscriptionOfferCodesGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionOfferCodesGetInstanceFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionOfferCodesGetInstanceFieldsSubscription.Name,
                "offerCodes" => SubscriptionOfferCodesGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionOfferCodesGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionOfferCodesGetInstanceFieldsSubscription.PricePoints,
                "prices" => SubscriptionOfferCodesGetInstanceFieldsSubscription.Prices,
                "productId" => SubscriptionOfferCodesGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionOfferCodesGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionOfferCodesGetInstanceFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionOfferCodesGetInstanceFieldsSubscription.ReviewNote,
                "state" => SubscriptionOfferCodesGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionOfferCodesGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionOfferCodesGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionOfferCodesGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionOfferCodesGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionOfferCodesGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}