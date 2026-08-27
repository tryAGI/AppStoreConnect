
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Subscription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionLocalizationsGetInstanceIncludeItem.Subscription => "subscription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscription" => SubscriptionLocalizationsGetInstanceIncludeItem.Subscription,
                _ => null,
            };
        }
    }
}