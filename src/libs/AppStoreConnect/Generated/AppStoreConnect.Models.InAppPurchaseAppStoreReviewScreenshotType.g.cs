
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseAppStoreReviewScreenshotType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseAppStoreReviewScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAppStoreReviewScreenshotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAppStoreReviewScreenshotType value)
        {
            return value switch
            {
                InAppPurchaseAppStoreReviewScreenshotType.InAppPurchaseAppStoreReviewScreenshots => "inAppPurchaseAppStoreReviewScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAppStoreReviewScreenshotType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAppStoreReviewScreenshots" => InAppPurchaseAppStoreReviewScreenshotType.InAppPurchaseAppStoreReviewScreenshots,
                _ => null,
            };
        }
    }
}