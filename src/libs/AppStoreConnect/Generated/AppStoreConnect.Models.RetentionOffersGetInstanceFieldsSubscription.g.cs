
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionOffersGetInstanceFieldsSubscription
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
        MarketSettings,
        /// <summary>
        ///
        /// </summary>
        MultiSeatStatus,
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
        RetentionMessage,
        /// <summary>
        ///
        /// </summary>
        RetentionMessageOffers,
        /// <summary>
        ///
        /// </summary>
        RetentionOffers,
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
    public static class RetentionOffersGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionOffersGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                RetentionOffersGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                RetentionOffersGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                RetentionOffersGetInstanceFieldsSubscription.Group => "group",
                RetentionOffersGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                RetentionOffersGetInstanceFieldsSubscription.Images => "images",
                RetentionOffersGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                RetentionOffersGetInstanceFieldsSubscription.MarketSettings => "marketSettings",
                RetentionOffersGetInstanceFieldsSubscription.MultiSeatStatus => "multiSeatStatus",
                RetentionOffersGetInstanceFieldsSubscription.Name => "name",
                RetentionOffersGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                RetentionOffersGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                RetentionOffersGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                RetentionOffersGetInstanceFieldsSubscription.Prices => "prices",
                RetentionOffersGetInstanceFieldsSubscription.ProductId => "productId",
                RetentionOffersGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                RetentionOffersGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                RetentionOffersGetInstanceFieldsSubscription.RetentionMessage => "retentionMessage",
                RetentionOffersGetInstanceFieldsSubscription.RetentionMessageOffers => "retentionMessageOffers",
                RetentionOffersGetInstanceFieldsSubscription.RetentionOffers => "retentionOffers",
                RetentionOffersGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                RetentionOffersGetInstanceFieldsSubscription.State => "state",
                RetentionOffersGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                RetentionOffersGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                RetentionOffersGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                RetentionOffersGetInstanceFieldsSubscription.Versions => "versions",
                RetentionOffersGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionOffersGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => RetentionOffersGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => RetentionOffersGetInstanceFieldsSubscription.FamilySharable,
                "group" => RetentionOffersGetInstanceFieldsSubscription.Group,
                "groupLevel" => RetentionOffersGetInstanceFieldsSubscription.GroupLevel,
                "images" => RetentionOffersGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => RetentionOffersGetInstanceFieldsSubscription.IntroductoryOffers,
                "marketSettings" => RetentionOffersGetInstanceFieldsSubscription.MarketSettings,
                "multiSeatStatus" => RetentionOffersGetInstanceFieldsSubscription.MultiSeatStatus,
                "name" => RetentionOffersGetInstanceFieldsSubscription.Name,
                "offerCodes" => RetentionOffersGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => RetentionOffersGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => RetentionOffersGetInstanceFieldsSubscription.PricePoints,
                "prices" => RetentionOffersGetInstanceFieldsSubscription.Prices,
                "productId" => RetentionOffersGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => RetentionOffersGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => RetentionOffersGetInstanceFieldsSubscription.PromotionalOffers,
                "retentionMessage" => RetentionOffersGetInstanceFieldsSubscription.RetentionMessage,
                "retentionMessageOffers" => RetentionOffersGetInstanceFieldsSubscription.RetentionMessageOffers,
                "retentionOffers" => RetentionOffersGetInstanceFieldsSubscription.RetentionOffers,
                "reviewNote" => RetentionOffersGetInstanceFieldsSubscription.ReviewNote,
                "state" => RetentionOffersGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => RetentionOffersGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => RetentionOffersGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => RetentionOffersGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => RetentionOffersGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => RetentionOffersGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}