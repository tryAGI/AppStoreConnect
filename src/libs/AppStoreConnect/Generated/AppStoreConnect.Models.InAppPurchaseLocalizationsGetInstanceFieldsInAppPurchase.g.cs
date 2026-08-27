
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase
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
    public static class InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase value)
        {
            return value switch
            {
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.Content => "content",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.ContentHosting => "contentHosting",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.FamilySharable => "familySharable",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.Images => "images",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.InAppPurchaseType => "inAppPurchaseType",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.Name => "name",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.OfferCodes => "offerCodes",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.PricePoints => "pricePoints",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.ProductId => "productId",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.PromotedPurchase => "promotedPurchase",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.ReviewNote => "reviewNote",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.State => "state",
                InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.AppStoreReviewScreenshot,
                "content" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.Content,
                "contentHosting" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.ContentHosting,
                "familySharable" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.FamilySharable,
                "iapPriceSchedule" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.IapPriceSchedule,
                "images" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.Images,
                "inAppPurchaseAvailability" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.InAppPurchaseLocalizations,
                "inAppPurchaseType" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.InAppPurchaseType,
                "name" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.Name,
                "offerCodes" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.OfferCodes,
                "pricePoints" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.PricePoints,
                "productId" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.ProductId,
                "promotedPurchase" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.PromotedPurchase,
                "reviewNote" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.ReviewNote,
                "state" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.State,
                "versions" => InAppPurchaseLocalizationsGetInstanceFieldsInAppPurchase.Versions,
                _ => null,
            };
        }
    }
}