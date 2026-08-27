
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionLocalizationCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionLocalizationCreateRequestDataType.SubscriptionLocalizations => "subscriptionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionLocalizations" => SubscriptionLocalizationCreateRequestDataType.SubscriptionLocalizations,
                _ => null,
            };
        }
    }
}