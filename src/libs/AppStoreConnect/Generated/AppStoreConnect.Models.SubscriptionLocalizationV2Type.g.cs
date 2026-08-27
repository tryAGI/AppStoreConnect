
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionLocalizationV2Type
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionLocalizationV2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationV2Type value)
        {
            return value switch
            {
                SubscriptionLocalizationV2Type.SubscriptionLocalizations => "subscriptionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationV2Type? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionLocalizations" => SubscriptionLocalizationV2Type.SubscriptionLocalizations,
                _ => null,
            };
        }
    }
}