
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupVersionCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroupVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupVersionCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionGroupVersionCreateRequestDataType.SubscriptionGroupVersions => "subscriptionGroupVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroupVersions" => SubscriptionGroupVersionCreateRequestDataType.SubscriptionGroupVersions,
                _ => null,
            };
        }
    }
}