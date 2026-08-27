
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase
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
    public static class InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.Content => "content",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.Images => "images",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.Name => "name",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.ProductId => "productId",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.State => "state",
                InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.State,
                "versions" => InAppPurchasesV2ContentGetToOneRelatedFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}