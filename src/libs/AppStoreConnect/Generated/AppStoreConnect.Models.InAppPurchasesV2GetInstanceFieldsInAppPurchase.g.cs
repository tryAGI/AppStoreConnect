
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2GetInstanceFieldsInAppPurchase
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
    public static class InAppPurchasesV2GetInstanceFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.Content => "content",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.Images => "images",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.Name => "name",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.ProductId => "productId",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.State => "state",
                InAppPurchasesV2GetInstanceFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.State,
                "versions" => InAppPurchasesV2GetInstanceFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}