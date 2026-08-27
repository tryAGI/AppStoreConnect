
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsInAppPurchase
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreReviewScreenshot,
        /// <summary>
        ///
        /// </summary>
        Apps,
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
        ReferenceName,
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
    public static class AppsGetInstanceFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsInAppPurchase value)
        {
            return value switch
            {
                AppsGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                AppsGetInstanceFieldsInAppPurchase.Apps => "apps",
                AppsGetInstanceFieldsInAppPurchase.Content => "content",
                AppsGetInstanceFieldsInAppPurchase.ContentHosting => "contentHosting",
                AppsGetInstanceFieldsInAppPurchase.FamilySharable => "familySharable",
                AppsGetInstanceFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                AppsGetInstanceFieldsInAppPurchase.Images => "images",
                AppsGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                AppsGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                AppsGetInstanceFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                AppsGetInstanceFieldsInAppPurchase.Name => "name",
                AppsGetInstanceFieldsInAppPurchase.OfferCodes => "offerCodes",
                AppsGetInstanceFieldsInAppPurchase.PricePoints => "pricePoints",
                AppsGetInstanceFieldsInAppPurchase.ProductId => "productId",
                AppsGetInstanceFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                AppsGetInstanceFieldsInAppPurchase.ReferenceName => "referenceName",
                AppsGetInstanceFieldsInAppPurchase.ReviewNote => "reviewNote",
                AppsGetInstanceFieldsInAppPurchase.State => "state",
                AppsGetInstanceFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => AppsGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot,
                "apps" => AppsGetInstanceFieldsInAppPurchase.Apps,
                "content" => AppsGetInstanceFieldsInAppPurchase.Content,
                "contentHosting" => AppsGetInstanceFieldsInAppPurchase.ContentHosting,
                "familySharable" => AppsGetInstanceFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => AppsGetInstanceFieldsInAppPurchase.IapPriceSchedule,
                "images" => AppsGetInstanceFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => AppsGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => AppsGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => AppsGetInstanceFieldsInAppPurchase.InAppPurchaseType,
                "name" => AppsGetInstanceFieldsInAppPurchase.Name,
                "offerCodes" => AppsGetInstanceFieldsInAppPurchase.OfferCodes,
                "pricePoints" => AppsGetInstanceFieldsInAppPurchase.PricePoints,
                "productId" => AppsGetInstanceFieldsInAppPurchase.ProductId,
                "promotedPurchase" => AppsGetInstanceFieldsInAppPurchase.PromotedPurchase,
                "referenceName" => AppsGetInstanceFieldsInAppPurchase.ReferenceName,
                "reviewNote" => AppsGetInstanceFieldsInAppPurchase.ReviewNote,
                "state" => AppsGetInstanceFieldsInAppPurchase.State,
                "versions" => AppsGetInstanceFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}