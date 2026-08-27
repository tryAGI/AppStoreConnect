
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionLocalizationsV2GetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionLocalizationsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                SubscriptionLocalizationsV2GetInstanceIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "version" => SubscriptionLocalizationsV2GetInstanceIncludeItem.Version,
                _ => null,
            };
        }
    }
}