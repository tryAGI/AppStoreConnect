
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseAppStoreReviewScreenshotCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseAppStoreReviewScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAppStoreReviewScreenshotCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAppStoreReviewScreenshotCreateRequestDataType value)
        {
            return value switch
            {
                InAppPurchaseAppStoreReviewScreenshotCreateRequestDataType.InAppPurchaseAppStoreReviewScreenshots => "inAppPurchaseAppStoreReviewScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAppStoreReviewScreenshotCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAppStoreReviewScreenshots" => InAppPurchaseAppStoreReviewScreenshotCreateRequestDataType.InAppPurchaseAppStoreReviewScreenshots,
                _ => null,
            };
        }
    }
}