
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAppStoreReviewScreenshotUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionAppStoreReviewScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAppStoreReviewScreenshotUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAppStoreReviewScreenshotUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionAppStoreReviewScreenshotUpdateRequestDataType.SubscriptionAppStoreReviewScreenshots => "subscriptionAppStoreReviewScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAppStoreReviewScreenshotUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionAppStoreReviewScreenshots" => SubscriptionAppStoreReviewScreenshotUpdateRequestDataType.SubscriptionAppStoreReviewScreenshots,
                _ => null,
            };
        }
    }
}