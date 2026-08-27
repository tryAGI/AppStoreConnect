
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseV2AppStoreReviewScreenshotLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchaseAppStoreReviewScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2AppStoreReviewScreenshotLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2AppStoreReviewScreenshotLinkageResponseDataType value)
        {
            return value switch
            {
                InAppPurchaseV2AppStoreReviewScreenshotLinkageResponseDataType.InAppPurchaseAppStoreReviewScreenshots => "inAppPurchaseAppStoreReviewScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2AppStoreReviewScreenshotLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAppStoreReviewScreenshots" => InAppPurchaseV2AppStoreReviewScreenshotLinkageResponseDataType.InAppPurchaseAppStoreReviewScreenshots,
                _ => null,
            };
        }
    }
}