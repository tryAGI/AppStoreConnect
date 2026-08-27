
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupLocalizationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationCreateRequestDataType.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupLocalizationCreateRequestDataType.SubscriptionGroupLocalizations,
                _ => null,
            };
        }
    }
}