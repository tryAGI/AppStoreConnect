
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionsGetInstanceFieldsSubscription
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
    public static class SubscriptionVersionsGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionsGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionVersionsGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionVersionsGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionVersionsGetInstanceFieldsSubscription.Group => "group",
                SubscriptionVersionsGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionVersionsGetInstanceFieldsSubscription.Images => "images",
                SubscriptionVersionsGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionVersionsGetInstanceFieldsSubscription.Name => "name",
                SubscriptionVersionsGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionVersionsGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionVersionsGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionVersionsGetInstanceFieldsSubscription.Prices => "prices",
                SubscriptionVersionsGetInstanceFieldsSubscription.ProductId => "productId",
                SubscriptionVersionsGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionVersionsGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionVersionsGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionVersionsGetInstanceFieldsSubscription.State => "state",
                SubscriptionVersionsGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionVersionsGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionVersionsGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionVersionsGetInstanceFieldsSubscription.Versions => "versions",
                SubscriptionVersionsGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionsGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionVersionsGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionVersionsGetInstanceFieldsSubscription.FamilySharable,
                "group" => SubscriptionVersionsGetInstanceFieldsSubscription.Group,
                "groupLevel" => SubscriptionVersionsGetInstanceFieldsSubscription.GroupLevel,
                "images" => SubscriptionVersionsGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionVersionsGetInstanceFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionVersionsGetInstanceFieldsSubscription.Name,
                "offerCodes" => SubscriptionVersionsGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionVersionsGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionVersionsGetInstanceFieldsSubscription.PricePoints,
                "prices" => SubscriptionVersionsGetInstanceFieldsSubscription.Prices,
                "productId" => SubscriptionVersionsGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionVersionsGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionVersionsGetInstanceFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionVersionsGetInstanceFieldsSubscription.ReviewNote,
                "state" => SubscriptionVersionsGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionVersionsGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionVersionsGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionVersionsGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionVersionsGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionVersionsGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}