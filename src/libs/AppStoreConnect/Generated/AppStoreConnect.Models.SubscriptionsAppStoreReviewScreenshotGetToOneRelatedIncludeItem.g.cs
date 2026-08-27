
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscription" => SubscriptionsAppStoreReviewScreenshotGetToOneRelatedIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}