
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2GetInstanceIncludeItem
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
        OfferCodes,
        /// <summary>
        /// 
        /// </summary>
        PricePoints,
        /// <summary>
        /// 
        /// </summary>
        PromotedPurchase,
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchasesV2GetInstanceIncludeItem.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                InAppPurchasesV2GetInstanceIncludeItem.Content => "content",
                InAppPurchasesV2GetInstanceIncludeItem.IapPriceSchedule => "iapPriceSchedule",
                InAppPurchasesV2GetInstanceIncludeItem.Images => "images",
                InAppPurchasesV2GetInstanceIncludeItem.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                InAppPurchasesV2GetInstanceIncludeItem.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                InAppPurchasesV2GetInstanceIncludeItem.OfferCodes => "offerCodes",
                InAppPurchasesV2GetInstanceIncludeItem.PricePoints => "pricePoints",
                InAppPurchasesV2GetInstanceIncludeItem.PromotedPurchase => "promotedPurchase",
                InAppPurchasesV2GetInstanceIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => InAppPurchasesV2GetInstanceIncludeItem.AppStoreReviewScreenshot,
                "content" => InAppPurchasesV2GetInstanceIncludeItem.Content,
                "iapPriceSchedule" => InAppPurchasesV2GetInstanceIncludeItem.IapPriceSchedule,
                "images" => InAppPurchasesV2GetInstanceIncludeItem.Images,
                "inAppPurchaseAvailability" => InAppPurchasesV2GetInstanceIncludeItem.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => InAppPurchasesV2GetInstanceIncludeItem.InAppPurchaseLocalizations,
                "offerCodes" => InAppPurchasesV2GetInstanceIncludeItem.OfferCodes,
                "pricePoints" => InAppPurchasesV2GetInstanceIncludeItem.PricePoints,
                "promotedPurchase" => InAppPurchasesV2GetInstanceIncludeItem.PromotedPurchase,
                "versions" => InAppPurchasesV2GetInstanceIncludeItem.Versions,
                _ => null,
            };
        }
    }
}