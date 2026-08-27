
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription
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
    public static class InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscriptionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription value)
        {
            return value switch
            {
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.FamilySharable => "familySharable",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.Group => "group",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.GroupLevel => "groupLevel",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.Images => "images",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.IntroductoryOffers => "introductoryOffers",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.Name => "name",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.OfferCodes => "offerCodes",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.PlanAvailabilities => "planAvailabilities",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.PricePoints => "pricePoints",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.Prices => "prices",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.ProductId => "productId",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.PromotedPurchase => "promotedPurchase",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.PromotionalOffers => "promotionalOffers",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.ReviewNote => "reviewNote",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.State => "state",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionAvailability => "subscriptionAvailability",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionLocalizations => "subscriptionLocalizations",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionPeriod => "subscriptionPeriod",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.Versions => "versions",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.WinBackOffers => "winBackOffers",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.AppStoreReviewScreenshot,
                "familySharable" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.FamilySharable,
                "group" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.Group,
                "groupLevel" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.GroupLevel,
                "images" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.Images,
                "introductoryOffers" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.IntroductoryOffers,
                "name" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.Name,
                "offerCodes" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.OfferCodes,
                "planAvailabilities" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.PlanAvailabilities,
                "pricePoints" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.PricePoints,
                "prices" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.Prices,
                "productId" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.ProductId,
                "promotedPurchase" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.PromotedPurchase,
                "promotionalOffers" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.PromotionalOffers,
                "reviewNote" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.ReviewNote,
                "state" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.State,
                "subscriptionAvailability" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionAvailability,
                "subscriptionLocalizations" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionLocalizations,
                "subscriptionPeriod" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.SubscriptionPeriod,
                "versions" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.Versions,
                "winBackOffers" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsSubscription.WinBackOffers,
                _ => null,
            };
        }
    }
}