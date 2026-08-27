
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupVersionsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionGroupVersionsGetInstanceIncludeItem.Localizations => "localizations",
                SubscriptionGroupVersionsGetInstanceIncludeItem.SubscriptionGroup => "subscriptionGroup",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => SubscriptionGroupVersionsGetInstanceIncludeItem.Localizations,
                "subscriptionGroup" => SubscriptionGroupVersionsGetInstanceIncludeItem.SubscriptionGroup,
                _ => null,
            };
        }
    }
}