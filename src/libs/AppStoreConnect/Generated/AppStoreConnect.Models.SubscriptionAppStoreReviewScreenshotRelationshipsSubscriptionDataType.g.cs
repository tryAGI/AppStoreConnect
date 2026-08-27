
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType value)
        {
            return value switch
            {
                SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => SubscriptionAppStoreReviewScreenshotRelationshipsSubscriptionDataType.Subscriptions,
                _ => null,
            };
        }
    }
}