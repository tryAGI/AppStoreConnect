
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription
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
    public static class AppsSubscriptionGroupsGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.Group => "group",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.Images => "images",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.Name => "name",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.Prices => "prices",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.ProductId => "productId",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.State => "state",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.Versions => "versions",
                AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "name" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.Prices,
                "productId" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => AppsSubscriptionGroupsGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}