
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.Group => "group",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.Images => "images",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.Name => "name",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.Prices => "prices",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.ProductId => "productId",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.State => "state",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.Versions => "versions",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "name" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.Prices,
                "productId" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}