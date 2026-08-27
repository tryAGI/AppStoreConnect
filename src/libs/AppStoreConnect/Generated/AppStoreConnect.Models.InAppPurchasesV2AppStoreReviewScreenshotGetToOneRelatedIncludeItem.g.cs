
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedIncludeItem.InAppPurchaseV2 => "inAppPurchaseV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseV2" => InAppPurchasesV2AppStoreReviewScreenshotGetToOneRelatedIncludeItem.InAppPurchaseV2,
                _ => null,
            };
        }
    }
}