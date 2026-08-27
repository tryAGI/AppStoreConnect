
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription
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
    public static class SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.Group => "group",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.Images => "images",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.Name => "name",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.State => "state",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsPromotionalOffersGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}