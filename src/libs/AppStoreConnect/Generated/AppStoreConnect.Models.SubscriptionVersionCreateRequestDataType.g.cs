
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionVersionCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionVersionCreateRequestDataType.SubscriptionVersions => "subscriptionVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionVersions" => SubscriptionVersionCreateRequestDataType.SubscriptionVersions,
                _ => null,
            };
        }
    }
}