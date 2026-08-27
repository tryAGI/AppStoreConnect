
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription
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
    public static class SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.Group => "group",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.Images => "images",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.Name => "name",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.State => "state",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}