
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupLocalizationV2UpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupLocalizationV2UpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupLocalizationV2UpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionGroupLocalizationV2UpdateRequestDataType.SubscriptionGroupLocalizations => "subscriptionGroupLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupLocalizationV2UpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupLocalizations" => SubscriptionGroupLocalizationV2UpdateRequestDataType.SubscriptionGroupLocalizations,
                _ => null,
            };
        }
    }
}