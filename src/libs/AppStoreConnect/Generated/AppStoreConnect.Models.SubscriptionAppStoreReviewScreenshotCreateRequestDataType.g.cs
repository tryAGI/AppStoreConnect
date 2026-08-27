
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionAppStoreReviewScreenshotCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionAppStoreReviewScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAppStoreReviewScreenshotCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAppStoreReviewScreenshotCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionAppStoreReviewScreenshotCreateRequestDataType.SubscriptionAppStoreReviewScreenshots => "subscriptionAppStoreReviewScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAppStoreReviewScreenshotCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionAppStoreReviewScreenshots" => SubscriptionAppStoreReviewScreenshotCreateRequestDataType.SubscriptionAppStoreReviewScreenshots,
                _ => null,
            };
        }
    }
}