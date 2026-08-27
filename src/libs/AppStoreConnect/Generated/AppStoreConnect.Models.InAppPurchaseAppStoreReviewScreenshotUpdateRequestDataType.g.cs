
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseAppStoreReviewScreenshotUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseAppStoreReviewScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAppStoreReviewScreenshotUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAppStoreReviewScreenshotUpdateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseAppStoreReviewScreenshotUpdateRequestDataType.InAppPurchaseAppStoreReviewScreenshots => "inAppPurchaseAppStoreReviewScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAppStoreReviewScreenshotUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAppStoreReviewScreenshots" => InAppPurchaseAppStoreReviewScreenshotUpdateRequestDataType.InAppPurchaseAppStoreReviewScreenshots,
                _ => null,
            };
        }
    }
}