
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.Group => "group",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.Images => "images",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.MarketSettings => "marketSettings",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.MultiSeatStatus => "multiSeatStatus",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.Name => "name",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.Prices => "prices",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.ProductId => "productId",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.RetentionMessage => "retentionMessage",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.RetentionMessageOffers => "retentionMessageOffers",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.RetentionOffers => "retentionOffers",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.State => "state",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.Versions => "versions",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "marketSettings" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.MarketSettings,
                "multiSeatStatus" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.MultiSeatStatus,
                "name" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.Prices,
                "productId" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "retentionMessage" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.RetentionMessage,
                "retentionMessageOffers" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.RetentionMessageOffers,
                "retentionOffers" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.RetentionOffers,
                "reviewNote" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}