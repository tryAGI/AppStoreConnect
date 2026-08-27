
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription
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
    public static class SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.Group => "group",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.Images => "images",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.Name => "name",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.State => "state",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}