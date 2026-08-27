
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionGroupCreateRequestDataType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroups" => SubscriptionGroupCreateRequestDataType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}