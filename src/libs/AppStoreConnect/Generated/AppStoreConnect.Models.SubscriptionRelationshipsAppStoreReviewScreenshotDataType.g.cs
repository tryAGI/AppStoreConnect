
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRelationshipsAppStoreReviewScreenshotDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionAppStoreReviewScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsAppStoreReviewScreenshotDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsAppStoreReviewScreenshotDataType value)
        {
            return value switch
            {
                SubscriptionRelationshipsAppStoreReviewScreenshotDataType.SubscriptionAppStoreReviewScreenshots => "subscriptionAppStoreReviewScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsAppStoreReviewScreenshotDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionAppStoreReviewScreenshots" => SubscriptionRelationshipsAppStoreReviewScreenshotDataType.SubscriptionAppStoreReviewScreenshots,
                _ => null,
            };
        }
    }
}