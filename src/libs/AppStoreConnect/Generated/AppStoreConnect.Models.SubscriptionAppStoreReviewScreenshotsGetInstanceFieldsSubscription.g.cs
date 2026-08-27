
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription
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
    public static class SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.Group => "group",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.Images => "images",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.Name => "name",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.Prices => "prices",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.ProductId => "productId",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.State => "state",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.Versions => "versions",
                SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.FamilySharable,
                "group" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.Group,
                "groupLevel" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.GroupLevel,
                "images" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.Name,
                "offerCodes" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.PricePoints,
                "prices" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.Prices,
                "productId" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.ReviewNote,
                "state" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionAppStoreReviewScreenshotsGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}