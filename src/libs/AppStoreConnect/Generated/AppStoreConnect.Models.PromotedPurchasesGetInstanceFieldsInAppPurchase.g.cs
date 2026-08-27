
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PromotedPurchasesGetInstanceFieldsInAppPurchase
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewScreenshot,
        /// <summary>
        ///
        /// </summary>
        Content,
        /// <summary>
        ///
        /// </summary>
        ContentHosting,
        /// <summary>
        ///
        /// </summary>
        FamilySharable,
        /// <summary>
        ///
        /// </summary>
        IapPriceSchedule,
        /// <summary>
        ///
        /// </summary>
        Images,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseAvailability,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseLocalizations,
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseType,
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
        PricePoints,
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
        ReviewNote,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromotedPurchasesGetInstanceFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromotedPurchasesGetInstanceFieldsInAppPurchase value)
        {
            return value switch
            {
                PromotedPurchasesGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.Content => "content",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.ContentHosting => "contentHosting",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.FamilySharable => "familySharable",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.Images => "images",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.Name => "name",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.OfferCodes => "offerCodes",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.PricePoints => "pricePoints",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.ProductId => "productId",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.ReviewNote => "reviewNote",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.State => "state",
                PromotedPurchasesGetInstanceFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromotedPurchasesGetInstanceFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => PromotedPurchasesGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => PromotedPurchasesGetInstanceFieldsInAppPurchase.Content,
                "contentHosting" => PromotedPurchasesGetInstanceFieldsInAppPurchase.ContentHosting,
                "familySharable" => PromotedPurchasesGetInstanceFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => PromotedPurchasesGetInstanceFieldsInAppPurchase.IapPriceSchedule,
                "images" => PromotedPurchasesGetInstanceFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => PromotedPurchasesGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => PromotedPurchasesGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => PromotedPurchasesGetInstanceFieldsInAppPurchase.InAppPurchaseType,
                "name" => PromotedPurchasesGetInstanceFieldsInAppPurchase.Name,
                "offerCodes" => PromotedPurchasesGetInstanceFieldsInAppPurchase.OfferCodes,
                "pricePoints" => PromotedPurchasesGetInstanceFieldsInAppPurchase.PricePoints,
                "productId" => PromotedPurchasesGetInstanceFieldsInAppPurchase.ProductId,
                "promotedPurchase" => PromotedPurchasesGetInstanceFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => PromotedPurchasesGetInstanceFieldsInAppPurchase.ReviewNote,
                "state" => PromotedPurchasesGetInstanceFieldsInAppPurchase.State,
                "versions" => PromotedPurchasesGetInstanceFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}