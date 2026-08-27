
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationsGetInstanceIncludeItem.SubscriptionGroup => "subscriptionGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroup" => SubscriptionGroupLocalizationsGetInstanceIncludeItem.SubscriptionGroup,
                _ => null,
            };
        }
    }
}