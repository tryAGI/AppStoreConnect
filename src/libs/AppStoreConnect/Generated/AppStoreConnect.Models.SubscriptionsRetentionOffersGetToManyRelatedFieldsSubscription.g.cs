
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription
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
    public static class SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.Group => "group",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.Images => "images",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.MarketSettings => "marketSettings",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.MultiSeatStatus => "multiSeatStatus",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.Name => "name",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.RetentionMessage => "retentionMessage",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.RetentionMessageOffers => "retentionMessageOffers",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.RetentionOffers => "retentionOffers",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.State => "state",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "marketSettings" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.MarketSettings,
                "multiSeatStatus" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.MultiSeatStatus,
                "name" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "retentionMessage" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.RetentionMessage,
                "retentionMessageOffers" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.RetentionMessageOffers,
                "retentionOffers" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.RetentionOffers,
                "reviewNote" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsRetentionOffersGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}