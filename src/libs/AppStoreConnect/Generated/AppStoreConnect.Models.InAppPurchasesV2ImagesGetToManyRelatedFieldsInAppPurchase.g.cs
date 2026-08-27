
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase
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
    public static class InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.Content => "content",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.Images => "images",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.Name => "name",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.ProductId => "productId",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.State => "state",
                InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.State,
                "versions" => InAppPurchasesV2ImagesGetToManyRelatedFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}