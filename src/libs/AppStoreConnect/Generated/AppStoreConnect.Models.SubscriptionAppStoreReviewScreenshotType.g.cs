
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAppStoreReviewScreenshotType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionAppStoreReviewScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAppStoreReviewScreenshotTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAppStoreReviewScreenshotType value)
        {
            return value switch
            {
                SubscriptionAppStoreReviewScreenshotType.SubscriptionAppStoreReviewScreenshots => "subscriptionAppStoreReviewScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAppStoreReviewScreenshotType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionAppStoreReviewScreenshots" => SubscriptionAppStoreReviewScreenshotType.SubscriptionAppStoreReviewScreenshots,
                _ => null,
            };
        }
    }
}