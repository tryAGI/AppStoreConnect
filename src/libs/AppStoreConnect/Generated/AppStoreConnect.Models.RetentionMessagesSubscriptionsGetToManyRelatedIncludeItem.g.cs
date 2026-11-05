
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewScreenshot,
        /// <summary>
        ///
        /// </summary>
        Group,
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
        OfferCodes,
        /// <summary>
        ///
        /// </summary>
        PlanAvailabilities,
        /// <summary>
        ///
        /// </summary>
        Prices,
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
        SubscriptionAvailability,
        /// <summary>
        ///
        /// </summary>
        SubscriptionLocalizations,
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.Group => "group",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.Images => "images",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.IntroductoryOffers => "introductoryOffers",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.OfferCodes => "offerCodes",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.PlanAvailabilities => "planAvailabilities",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.Prices => "prices",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.PromotedPurchase => "promotedPurchase",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.PromotionalOffers => "promotionalOffers",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.RetentionMessage => "retentionMessage",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.RetentionMessageOffers => "retentionMessageOffers",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.RetentionOffers => "retentionOffers",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.SubscriptionAvailability => "subscriptionAvailability",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.SubscriptionLocalizations => "subscriptionLocalizations",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.Versions => "versions",
                RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.AppStoreReviewScreenshot,
                "group" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.Group,
                "images" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.Images,
                "introductoryOffers" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.IntroductoryOffers,
                "offerCodes" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.OfferCodes,
                "planAvailabilities" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.PlanAvailabilities,
                "prices" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.Prices,
                "promotedPurchase" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.PromotedPurchase,
                "promotionalOffers" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.PromotionalOffers,
                "retentionMessage" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.RetentionMessage,
                "retentionMessageOffers" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.RetentionMessageOffers,
                "retentionOffers" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.RetentionOffers,
                "subscriptionAvailability" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.SubscriptionAvailability,
                "subscriptionLocalizations" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.SubscriptionLocalizations,
                "versions" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.Versions,
                "winBackOffers" => RetentionMessagesSubscriptionsGetToManyRelatedIncludeItem.WinBackOffers,
                _ => null,
            };
        }
    }
}