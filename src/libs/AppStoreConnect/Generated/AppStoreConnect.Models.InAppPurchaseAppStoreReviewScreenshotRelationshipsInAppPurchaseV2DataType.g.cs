
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType
    {
        /// <summary>
        ///
        /// </summary>
        InAppPurchases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType value)
        {
            return value switch
            {
                InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType.InAppPurchases => "inAppPurchases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "inAppPurchases" => InAppPurchaseAppStoreReviewScreenshotRelationshipsInAppPurchaseV2DataType.InAppPurchases,
                _ => null,
            };
        }
    }
}