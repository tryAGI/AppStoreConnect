
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription
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
    public static class SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.Group => "group",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.Images => "images",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.MarketSettings => "marketSettings",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.MultiSeatStatus => "multiSeatStatus",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.Name => "name",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.RetentionMessage => "retentionMessage",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.RetentionMessageOffers => "retentionMessageOffers",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.RetentionOffers => "retentionOffers",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.State => "state",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "marketSettings" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.MarketSettings,
                "multiSeatStatus" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.MultiSeatStatus,
                "name" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "retentionMessage" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.RetentionMessage,
                "retentionMessageOffers" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.RetentionMessageOffers,
                "retentionOffers" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.RetentionOffers,
                "reviewNote" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsRetentionMessageOffersGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}