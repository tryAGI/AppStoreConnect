
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription
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
    public static class SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.Group => "group",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.Images => "images",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.Name => "name",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.State => "state",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsPromotedPurchaseGetToOneRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}