
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAppStoreReviewScreenshotLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionAppStoreReviewScreenshots,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAppStoreReviewScreenshotLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAppStoreReviewScreenshotLinkageResponseDataType value)
        {
            return value switch
            {
                SubscriptionAppStoreReviewScreenshotLinkageResponseDataType.SubscriptionAppStoreReviewScreenshots => "subscriptionAppStoreReviewScreenshots",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAppStoreReviewScreenshotLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionAppStoreReviewScreenshots" => SubscriptionAppStoreReviewScreenshotLinkageResponseDataType.SubscriptionAppStoreReviewScreenshots,
                _ => null,
            };
        }
    }
}