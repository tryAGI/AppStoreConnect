
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase
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
    public static class InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.Content => "content",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.Images => "images",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.Name => "name",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.ProductId => "productId",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.State => "state",
                InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.State,
                "versions" => InAppPurchasesV2VersionsGetToManyRelatedFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}