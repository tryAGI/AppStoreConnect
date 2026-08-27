
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsInAppPurchase
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
    public static class CiProductsAppGetToOneRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.Apps => "apps",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.Content => "content",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.ContentHosting => "contentHosting",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.FamilySharable => "familySharable",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.Images => "images",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.Name => "name",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.OfferCodes => "offerCodes",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.PricePoints => "pricePoints",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.ProductId => "productId",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.ReferenceName => "referenceName",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.ReviewNote => "reviewNote",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.State => "state",
                CiProductsAppGetToOneRelatedFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.AppStoreReviewScreenshot,
                "apps" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.Apps,
                "content" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.Content,
                "contentHosting" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.ContentHosting,
                "familySharable" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.IapPriceSchedule,
                "images" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.InAppPurchaseType,
                "name" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.Name,
                "offerCodes" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.OfferCodes,
                "pricePoints" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.PricePoints,
                "productId" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.ProductId,
                "promotedPurchase" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.PromotedPurchase,
                "referenceName" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.ReferenceName,
                "reviewNote" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.ReviewNote,
                "state" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.State,
                "versions" => CiProductsAppGetToOneRelatedFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}