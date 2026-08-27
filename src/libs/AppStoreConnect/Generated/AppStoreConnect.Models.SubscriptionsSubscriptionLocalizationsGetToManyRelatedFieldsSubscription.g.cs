
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription
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
    public static class SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.Group => "group",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.Images => "images",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.Name => "name",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.State => "state",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsSubscriptionLocalizationsGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}