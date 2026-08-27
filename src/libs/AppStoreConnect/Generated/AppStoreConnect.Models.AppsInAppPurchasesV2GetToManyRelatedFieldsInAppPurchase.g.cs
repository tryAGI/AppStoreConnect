
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase
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
    public static class AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.Content => "content",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.ContentHosting => "contentHosting",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.FamilySharable => "familySharable",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.Images => "images",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.Name => "name",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.OfferCodes => "offerCodes",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.PricePoints => "pricePoints",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.ProductId => "productId",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.ReviewNote => "reviewNote",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.State => "state",
                AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.Content,
                "contentHosting" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.ContentHosting,
                "familySharable" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.IapPriceSchedule,
                "images" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.InAppPurchaseType,
                "name" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.Name,
                "offerCodes" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.OfferCodes,
                "pricePoints" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.PricePoints,
                "productId" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.ProductId,
                "promotedPurchase" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.ReviewNote,
                "state" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.State,
                "versions" => AppsInAppPurchasesV2GetToManyRelatedFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}