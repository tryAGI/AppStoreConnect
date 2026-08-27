
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsInAppPurchasesV2GetToManyRelatedIncludeItem
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
        PromotedPurchase,
        /// <summary>
        /// 
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsInAppPurchasesV2GetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsInAppPurchasesV2GetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsInAppPurchasesV2GetToManyRelatedIncludeItem.AppStoreReviewScreenshot => "appStoreReviewScreenshot",
                AppsInAppPurchasesV2GetToManyRelatedIncludeItem.Content => "content",
                AppsInAppPurchasesV2GetToManyRelatedIncludeItem.IapPriceSchedule => "iapPriceSchedule",
                AppsInAppPurchasesV2GetToManyRelatedIncludeItem.Images => "images",
                AppsInAppPurchasesV2GetToManyRelatedIncludeItem.InAppPurchaseAvailability => "inAppPurchaseAvailability",
                AppsInAppPurchasesV2GetToManyRelatedIncludeItem.InAppPurchaseLocalizations => "inAppPurchaseLocalizations",
                AppsInAppPurchasesV2GetToManyRelatedIncludeItem.OfferCodes => "offerCodes",
                AppsInAppPurchasesV2GetToManyRelatedIncludeItem.PromotedPurchase => "promotedPurchase",
                AppsInAppPurchasesV2GetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsInAppPurchasesV2GetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreReviewScreenshot" => AppsInAppPurchasesV2GetToManyRelatedIncludeItem.AppStoreReviewScreenshot,
                "content" => AppsInAppPurchasesV2GetToManyRelatedIncludeItem.Content,
                "iapPriceSchedule" => AppsInAppPurchasesV2GetToManyRelatedIncludeItem.IapPriceSchedule,
                "images" => AppsInAppPurchasesV2GetToManyRelatedIncludeItem.Images,
                "inAppPurchaseAvailability" => AppsInAppPurchasesV2GetToManyRelatedIncludeItem.InAppPurchaseAvailability,
                "inAppPurchaseLocalizations" => AppsInAppPurchasesV2GetToManyRelatedIncludeItem.InAppPurchaseLocalizations,
                "offerCodes" => AppsInAppPurchasesV2GetToManyRelatedIncludeItem.OfferCodes,
                "promotedPurchase" => AppsInAppPurchasesV2GetToManyRelatedIncludeItem.PromotedPurchase,
                "versions" => AppsInAppPurchasesV2GetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}