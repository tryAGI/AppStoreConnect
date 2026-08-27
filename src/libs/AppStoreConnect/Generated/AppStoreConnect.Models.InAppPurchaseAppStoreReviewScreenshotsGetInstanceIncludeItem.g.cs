
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseAppStoreReviewScreenshotsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseV2,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAppStoreReviewScreenshotsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAppStoreReviewScreenshotsGetInstanceIncludeItem value)
        {
            return value switch
            {
                InAppPurchaseAppStoreReviewScreenshotsGetInstanceIncludeItem.InAppPurchaseV2 => "inAppPurchaseV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAppStoreReviewScreenshotsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseV2" => InAppPurchaseAppStoreReviewScreenshotsGetInstanceIncludeItem.InAppPurchaseV2,
                _ => null,
            };
        }
    }
}