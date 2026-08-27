
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupLocalizationsV2GetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupLocalizationsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationsV2GetInstanceIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "version" => SubscriptionGroupLocalizationsV2GetInstanceIncludeItem.Version,
                _ => null,
            };
        }
    }
}