
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsRetentionMessagesGetToManyRelatedFieldsSubscription
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
    public static class AppsRetentionMessagesGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsRetentionMessagesGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.Group => "group",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.Images => "images",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.MarketSettings => "marketSettings",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.MultiSeatStatus => "multiSeatStatus",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.Name => "name",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.Prices => "prices",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.ProductId => "productId",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.RetentionMessage => "retentionMessage",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.RetentionMessageOffers => "retentionMessageOffers",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.RetentionOffers => "retentionOffers",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.State => "state",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.Versions => "versions",
                AppsRetentionMessagesGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsRetentionMessagesGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "marketSettings" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.MarketSettings,
                "multiSeatStatus" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.MultiSeatStatus,
                "name" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.Prices,
                "productId" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "retentionMessage" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.RetentionMessage,
                "retentionMessageOffers" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.RetentionMessageOffers,
                "retentionOffers" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.RetentionOffers,
                "reviewNote" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => AppsRetentionMessagesGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}