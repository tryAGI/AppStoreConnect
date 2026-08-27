
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsInAppPurchase
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
    public static class AppsGetCollectionFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsInAppPurchase value)
        {
            return value switch
            {
                AppsGetCollectionFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                AppsGetCollectionFieldsInAppPurchase.Apps => "apps",
                AppsGetCollectionFieldsInAppPurchase.Content => "content",
                AppsGetCollectionFieldsInAppPurchase.ContentHosting => "contentHosting",
                AppsGetCollectionFieldsInAppPurchase.FamilySharable => "familySharable",
                AppsGetCollectionFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                AppsGetCollectionFieldsInAppPurchase.Images => "images",
                AppsGetCollectionFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                AppsGetCollectionFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                AppsGetCollectionFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                AppsGetCollectionFieldsInAppPurchase.Name => "name",
                AppsGetCollectionFieldsInAppPurchase.OfferCodes => "offerCodes",
                AppsGetCollectionFieldsInAppPurchase.PricePoints => "pricePoints",
                AppsGetCollectionFieldsInAppPurchase.ProductId => "productId",
                AppsGetCollectionFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                AppsGetCollectionFieldsInAppPurchase.ReferenceName => "referenceName",
                AppsGetCollectionFieldsInAppPurchase.ReviewNote => "reviewNote",
                AppsGetCollectionFieldsInAppPurchase.State => "state",
                AppsGetCollectionFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => AppsGetCollectionFieldsInAppPurchase.AppStoreReviewScreenshot,
                "apps" => AppsGetCollectionFieldsInAppPurchase.Apps,
                "content" => AppsGetCollectionFieldsInAppPurchase.Content,
                "contentHosting" => AppsGetCollectionFieldsInAppPurchase.ContentHosting,
                "familySharable" => AppsGetCollectionFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => AppsGetCollectionFieldsInAppPurchase.IapPriceSchedule,
                "images" => AppsGetCollectionFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => AppsGetCollectionFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => AppsGetCollectionFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => AppsGetCollectionFieldsInAppPurchase.InAppPurchaseType,
                "name" => AppsGetCollectionFieldsInAppPurchase.Name,
                "offerCodes" => AppsGetCollectionFieldsInAppPurchase.OfferCodes,
                "pricePoints" => AppsGetCollectionFieldsInAppPurchase.PricePoints,
                "productId" => AppsGetCollectionFieldsInAppPurchase.ProductId,
                "promotedPurchase" => AppsGetCollectionFieldsInAppPurchase.PromotedPurchase,
                "referenceName" => AppsGetCollectionFieldsInAppPurchase.ReferenceName,
                "reviewNote" => AppsGetCollectionFieldsInAppPurchase.ReviewNote,
                "state" => AppsGetCollectionFieldsInAppPurchase.State,
                "versions" => AppsGetCollectionFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}