
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType
    {
        /// <summary>
        /// 
        /// </summary>
        InAppPurchaseAppStoreReviewScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType value)
        {
            return value switch
            {
                InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType.InAppPurchaseAppStoreReviewScreenshots => "inAppPurchaseAppStoreReviewScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchaseAppStoreReviewScreenshots" => InAppPurchaseV2RelationshipsAppStoreReviewScreenshotDataType.InAppPurchaseAppStoreReviewScreenshots,
                _ => null,
            };
        }
    }
}