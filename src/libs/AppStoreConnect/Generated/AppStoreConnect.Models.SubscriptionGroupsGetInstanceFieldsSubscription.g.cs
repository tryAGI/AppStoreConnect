
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupsGetInstanceFieldsSubscription
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
    public static class SubscriptionGroupsGetInstanceFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsGetInstanceFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionGroupsGetInstanceFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionGroupsGetInstanceFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionGroupsGetInstanceFieldsSubscription.Group => "group",
                SubscriptionGroupsGetInstanceFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionGroupsGetInstanceFieldsSubscription.Images => "images",
                SubscriptionGroupsGetInstanceFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionGroupsGetInstanceFieldsSubscription.Name => "name",
                SubscriptionGroupsGetInstanceFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionGroupsGetInstanceFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionGroupsGetInstanceFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionGroupsGetInstanceFieldsSubscription.Prices => "prices",
                SubscriptionGroupsGetInstanceFieldsSubscription.ProductId => "productId",
                SubscriptionGroupsGetInstanceFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionGroupsGetInstanceFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionGroupsGetInstanceFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionGroupsGetInstanceFieldsSubscription.State => "state",
                SubscriptionGroupsGetInstanceFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionGroupsGetInstanceFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionGroupsGetInstanceFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionGroupsGetInstanceFieldsSubscription.Versions => "versions",
                SubscriptionGroupsGetInstanceFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsGetInstanceFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionGroupsGetInstanceFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionGroupsGetInstanceFieldsSubscription.FamilySharable,
                "group" => SubscriptionGroupsGetInstanceFieldsSubscription.Group,
                "groupLevel" => SubscriptionGroupsGetInstanceFieldsSubscription.GroupLevel,
                "images" => SubscriptionGroupsGetInstanceFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionGroupsGetInstanceFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionGroupsGetInstanceFieldsSubscription.Name,
                "offerCodes" => SubscriptionGroupsGetInstanceFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionGroupsGetInstanceFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionGroupsGetInstanceFieldsSubscription.PricePoints,
                "prices" => SubscriptionGroupsGetInstanceFieldsSubscription.Prices,
                "productId" => SubscriptionGroupsGetInstanceFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionGroupsGetInstanceFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionGroupsGetInstanceFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionGroupsGetInstanceFieldsSubscription.ReviewNote,
                "state" => SubscriptionGroupsGetInstanceFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionGroupsGetInstanceFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionGroupsGetInstanceFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionGroupsGetInstanceFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionGroupsGetInstanceFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionGroupsGetInstanceFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}