
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionLocalizationUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionLocalizationUpdateRequestDataType.SubscriptionLocalizations => "subscriptionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionLocalizations" => SubscriptionLocalizationUpdateRequestDataType.SubscriptionLocalizations,
                _ => null,
            };
        }
    }
}