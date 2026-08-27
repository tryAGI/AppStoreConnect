
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionLocalizationV2UpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionLocalizationV2UpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationV2UpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionLocalizationV2UpdateRequestDataType.SubscriptionLocalizations => "subscriptionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationV2UpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionLocalizations" => SubscriptionLocalizationV2UpdateRequestDataType.SubscriptionLocalizations,
                _ => null,
            };
        }
    }
}