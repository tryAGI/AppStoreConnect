
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription
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
    public static class SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.Group => "group",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.Images => "images",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.MarketSettings => "marketSettings",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.MultiSeatStatus => "multiSeatStatus",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.Name => "name",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.RetentionMessage => "retentionMessage",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.RetentionMessageOffers => "retentionMessageOffers",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.RetentionOffers => "retentionOffers",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.State => "state",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.IntroductoryOffers,
                "marketSettings" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.MarketSettings,
                "multiSeatStatus" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.MultiSeatStatus,
                "name" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.PromotionalOffers,
                "retentionMessage" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.RetentionMessage,
                "retentionMessageOffers" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.RetentionMessageOffers,
                "retentionOffers" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.RetentionOffers,
                "reviewNote" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsRetentionMessageGetToOneRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}