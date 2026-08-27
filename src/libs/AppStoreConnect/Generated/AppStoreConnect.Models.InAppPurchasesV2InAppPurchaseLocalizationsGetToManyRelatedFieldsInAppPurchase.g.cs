
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase
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
    public static class InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.Content => "content",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.Images => "images",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.Name => "name",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.ProductId => "productId",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.State => "state",
                InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.State,
                "versions" => InAppPurchasesV2InAppPurchaseLocalizationsGetToManyRelatedFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}