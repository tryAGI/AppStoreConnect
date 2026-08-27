
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription
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
    public static class SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.Group => "group",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.Images => "images",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.Name => "name",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.State => "state",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsIntroductoryOffersGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}