
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase
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
    public static class InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.Content => "content",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.Images => "images",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.Name => "name",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.ProductId => "productId",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.State => "state",
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.State,
                "versions" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}