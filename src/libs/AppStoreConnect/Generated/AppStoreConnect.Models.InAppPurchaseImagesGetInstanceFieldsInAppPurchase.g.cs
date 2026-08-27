
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseImagesGetInstanceFieldsInAppPurchase
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
    public static class InAppPurchaseImagesGetInstanceFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseImagesGetInstanceFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.Content => "content",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.Images => "images",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.Name => "name",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.ProductId => "productId",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.State => "state",
                InAppPurchaseImagesGetInstanceFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseImagesGetInstanceFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.State,
                "versions" => InAppPurchaseImagesGetInstanceFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}