
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromotedPurchasesGetInstanceFieldsSubscription
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
    public static class PromotedPurchasesGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchasesGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                PromotedPurchasesGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                PromotedPurchasesGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                PromotedPurchasesGetInstanceFieldsSubscription.Group => "group",
                PromotedPurchasesGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                PromotedPurchasesGetInstanceFieldsSubscription.Images => "images",
                PromotedPurchasesGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                PromotedPurchasesGetInstanceFieldsSubscription.Name => "name",
                PromotedPurchasesGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                PromotedPurchasesGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                PromotedPurchasesGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                PromotedPurchasesGetInstanceFieldsSubscription.Prices => "prices",
                PromotedPurchasesGetInstanceFieldsSubscription.ProductId => "productId",
                PromotedPurchasesGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                PromotedPurchasesGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                PromotedPurchasesGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                PromotedPurchasesGetInstanceFieldsSubscription.State => "state",
                PromotedPurchasesGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                PromotedPurchasesGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                PromotedPurchasesGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                PromotedPurchasesGetInstanceFieldsSubscription.Versions => "versions",
                PromotedPurchasesGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchasesGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => PromotedPurchasesGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => PromotedPurchasesGetInstanceFieldsSubscription.FamilySharable,
                "group" => PromotedPurchasesGetInstanceFieldsSubscription.Group,
                "groupLevel" => PromotedPurchasesGetInstanceFieldsSubscription.GroupLevel,
                "images" => PromotedPurchasesGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => PromotedPurchasesGetInstanceFieldsSubscription.IntroductoryOffers,
                "name" => PromotedPurchasesGetInstanceFieldsSubscription.Name,
                "offerCodes" => PromotedPurchasesGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => PromotedPurchasesGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => PromotedPurchasesGetInstanceFieldsSubscription.PricePoints,
                "prices" => PromotedPurchasesGetInstanceFieldsSubscription.Prices,
                "productId" => PromotedPurchasesGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => PromotedPurchasesGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => PromotedPurchasesGetInstanceFieldsSubscription.PromotionalOffers,
                "reviewNote" => PromotedPurchasesGetInstanceFieldsSubscription.ReviewNote,
                "state" => PromotedPurchasesGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => PromotedPurchasesGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => PromotedPurchasesGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => PromotedPurchasesGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => PromotedPurchasesGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => PromotedPurchasesGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}