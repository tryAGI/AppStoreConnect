
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesGetInstanceFieldsSubscription
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
    public static class RetentionMessagesGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                RetentionMessagesGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                RetentionMessagesGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                RetentionMessagesGetInstanceFieldsSubscription.Group => "group",
                RetentionMessagesGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                RetentionMessagesGetInstanceFieldsSubscription.Images => "images",
                RetentionMessagesGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                RetentionMessagesGetInstanceFieldsSubscription.MarketSettings => "marketSettings",
                RetentionMessagesGetInstanceFieldsSubscription.MultiSeatStatus => "multiSeatStatus",
                RetentionMessagesGetInstanceFieldsSubscription.Name => "name",
                RetentionMessagesGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                RetentionMessagesGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                RetentionMessagesGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                RetentionMessagesGetInstanceFieldsSubscription.Prices => "prices",
                RetentionMessagesGetInstanceFieldsSubscription.ProductId => "productId",
                RetentionMessagesGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                RetentionMessagesGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                RetentionMessagesGetInstanceFieldsSubscription.RetentionMessage => "retentionMessage",
                RetentionMessagesGetInstanceFieldsSubscription.RetentionMessageOffers => "retentionMessageOffers",
                RetentionMessagesGetInstanceFieldsSubscription.RetentionOffers => "retentionOffers",
                RetentionMessagesGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                RetentionMessagesGetInstanceFieldsSubscription.State => "state",
                RetentionMessagesGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                RetentionMessagesGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                RetentionMessagesGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                RetentionMessagesGetInstanceFieldsSubscription.Versions => "versions",
                RetentionMessagesGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => RetentionMessagesGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => RetentionMessagesGetInstanceFieldsSubscription.FamilySharable,
                "group" => RetentionMessagesGetInstanceFieldsSubscription.Group,
                "groupLevel" => RetentionMessagesGetInstanceFieldsSubscription.GroupLevel,
                "images" => RetentionMessagesGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => RetentionMessagesGetInstanceFieldsSubscription.IntroductoryOffers,
                "marketSettings" => RetentionMessagesGetInstanceFieldsSubscription.MarketSettings,
                "multiSeatStatus" => RetentionMessagesGetInstanceFieldsSubscription.MultiSeatStatus,
                "name" => RetentionMessagesGetInstanceFieldsSubscription.Name,
                "offerCodes" => RetentionMessagesGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => RetentionMessagesGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => RetentionMessagesGetInstanceFieldsSubscription.PricePoints,
                "prices" => RetentionMessagesGetInstanceFieldsSubscription.Prices,
                "productId" => RetentionMessagesGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => RetentionMessagesGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => RetentionMessagesGetInstanceFieldsSubscription.PromotionalOffers,
                "retentionMessage" => RetentionMessagesGetInstanceFieldsSubscription.RetentionMessage,
                "retentionMessageOffers" => RetentionMessagesGetInstanceFieldsSubscription.RetentionMessageOffers,
                "retentionOffers" => RetentionMessagesGetInstanceFieldsSubscription.RetentionOffers,
                "reviewNote" => RetentionMessagesGetInstanceFieldsSubscription.ReviewNote,
                "state" => RetentionMessagesGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => RetentionMessagesGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => RetentionMessagesGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => RetentionMessagesGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => RetentionMessagesGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => RetentionMessagesGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}