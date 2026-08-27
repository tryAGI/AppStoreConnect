
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupVersionCreateRequestDataRelationshipsSubscriptionGroupDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupVersionCreateRequestDataRelationshipsSubscriptionGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupVersionCreateRequestDataRelationshipsSubscriptionGroupDataType value)
        {
            return value switch
            {
                SubscriptionGroupVersionCreateRequestDataRelationshipsSubscriptionGroupDataType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupVersionCreateRequestDataRelationshipsSubscriptionGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroups" => SubscriptionGroupVersionCreateRequestDataRelationshipsSubscriptionGroupDataType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}