
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase
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
    public static class InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.Content => "content",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.Images => "images",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.Name => "name",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.ProductId => "productId",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.State => "state",
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.State,
                "versions" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}