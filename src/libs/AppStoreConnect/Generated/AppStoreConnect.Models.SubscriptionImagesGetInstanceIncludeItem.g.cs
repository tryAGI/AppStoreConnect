
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionImagesGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionImagesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionImagesGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionImagesGetInstanceIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionImagesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscription" => SubscriptionImagesGetInstanceIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}