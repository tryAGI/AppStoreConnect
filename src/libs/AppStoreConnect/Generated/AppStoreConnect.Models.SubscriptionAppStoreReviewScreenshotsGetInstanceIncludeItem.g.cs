
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionAppStoreReviewScreenshotsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAppStoreReviewScreenshotsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAppStoreReviewScreenshotsGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionAppStoreReviewScreenshotsGetInstanceIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAppStoreReviewScreenshotsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscription" => SubscriptionAppStoreReviewScreenshotsGetInstanceIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}