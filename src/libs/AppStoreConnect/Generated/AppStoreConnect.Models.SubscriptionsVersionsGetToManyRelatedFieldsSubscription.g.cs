
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsVersionsGetToManyRelatedFieldsSubscription
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
    public static class SubscriptionsVersionsGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsVersionsGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.Group => "group",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.Images => "images",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.Name => "name",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.Prices => "prices",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.State => "state",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.Versions => "versions",
                SubscriptionsVersionsGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsVersionsGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionsVersionsGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}