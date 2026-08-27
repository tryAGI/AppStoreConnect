
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionGroupUpdateRequestDataType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroups" => SubscriptionGroupUpdateRequestDataType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}