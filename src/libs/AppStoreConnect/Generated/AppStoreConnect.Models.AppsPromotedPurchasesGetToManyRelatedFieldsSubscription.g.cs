
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsPromotedPurchasesGetToManyRelatedFieldsSubscription
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
    public static class AppsPromotedPurchasesGetToManyRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsPromotedPurchasesGetToManyRelatedFieldsSubscription value)
        {
            return value switch
            {
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.FamilySharable => "familySharable",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.Group => "group",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.GroupLevel => "groupLevel",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.Images => "images",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.Name => "name",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.OfferCodes => "offerCodes",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.PricePoints => "pricePoints",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.Prices => "prices",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.ProductId => "productId",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.ReviewNote => "reviewNote",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.State => "state",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.Versions => "versions",
                AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsPromotedPurchasesGetToManyRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.FamilySharable,
                "group" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.Group,
                "groupLevel" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.GroupLevel,
                "images" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.Images,
                "introductoryOffers" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.IntroductoryOffers,
                "name" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.Name,
                "offerCodes" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.PricePoints,
                "prices" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.Prices,
                "productId" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.ReviewNote,
                "state" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.State,
                "subscriptionAvailability" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.Versions,
                "winBackOffers" => AppsPromotedPurchasesGetToManyRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}