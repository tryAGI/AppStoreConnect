
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupVersionRelationshipsSubscriptionGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType value)
        {
            return value switch
            {
                SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroups" => SubscriptionGroupVersionRelationshipsSubscriptionGroupDataType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}