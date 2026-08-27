
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase
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
    public static class AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.Content => "content",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.ContentHosting => "contentHosting",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.FamilySharable => "familySharable",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.Images => "images",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.Name => "name",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.OfferCodes => "offerCodes",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.PricePoints => "pricePoints",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.ProductId => "productId",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.ReviewNote => "reviewNote",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.State => "state",
                AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.Content,
                "contentHosting" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.ContentHosting,
                "familySharable" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.IapPriceSchedule,
                "images" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseType,
                "name" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.Name,
                "offerCodes" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.OfferCodes,
                "pricePoints" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.PricePoints,
                "productId" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.ProductId,
                "promotedPurchase" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.ReviewNote,
                "state" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.State,
                "versions" => AppsPromotedPurchasesGetToManyRelatedFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}