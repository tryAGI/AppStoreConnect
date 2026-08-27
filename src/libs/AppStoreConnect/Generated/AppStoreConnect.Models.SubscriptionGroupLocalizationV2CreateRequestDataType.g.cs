
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupLocalizationV2CreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupLocalizationV2CreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationV2CreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationV2CreateRequestDataType.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationV2CreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupLocalizationV2CreateRequestDataType.SubscriptionGroupLocalizations,
                _ => null,
            };
        }
    }
}