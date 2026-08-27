
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase
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
    public static class InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Content => "content",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Images => "images",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Name => "name",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ProductId => "productId",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.State => "state",
                InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.State,
                "versions" => InAppPurchasesV2PromotedPurchaseGetToOneRelatedFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}