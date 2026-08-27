
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscription
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
    public static class SubscriptionsGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsGetInstanceFieldsSubscription.Group => "group",
                SubscriptionsGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsGetInstanceFieldsSubscription.Images => "images",
                SubscriptionsGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsGetInstanceFieldsSubscription.Name => "name",
                SubscriptionsGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsGetInstanceFieldsSubscription.Prices => "prices",
                SubscriptionsGetInstanceFieldsSubscription.ProductId => "productId",
                SubscriptionsGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsGetInstanceFieldsSubscription.State => "state",
                SubscriptionsGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsGetInstanceFieldsSubscription.Versions => "versions",
                SubscriptionsGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsGetInstanceFieldsSubscription.FamilySharable,
                "group" => SubscriptionsGetInstanceFieldsSubscription.Group,
                "groupLevel" => SubscriptionsGetInstanceFieldsSubscription.GroupLevel,
                "images" => SubscriptionsGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsGetInstanceFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionsGetInstanceFieldsSubscription.Name,
                "offerCodes" => SubscriptionsGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsGetInstanceFieldsSubscription.PricePoints,
                "prices" => SubscriptionsGetInstanceFieldsSubscription.Prices,
                "productId" => SubscriptionsGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsGetInstanceFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionsGetInstanceFieldsSubscription.ReviewNote,
                "state" => SubscriptionsGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}