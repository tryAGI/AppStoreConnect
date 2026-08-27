
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsImagesGetToManyRelatedFieldsSubscription
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
    public static class SubscriptionsImagesGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsImagesGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.Group => "group",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.Images => "images",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.Name => "name",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.State => "state",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsImagesGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsImagesGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsImagesGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}