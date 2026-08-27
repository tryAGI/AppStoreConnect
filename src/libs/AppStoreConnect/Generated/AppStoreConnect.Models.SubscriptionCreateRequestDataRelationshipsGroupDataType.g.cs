
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionCreateRequestDataRelationshipsGroupDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionCreateRequestDataRelationshipsGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionCreateRequestDataRelationshipsGroupDataType value)
        {
            return value switch
            {
                SubscriptionCreateRequestDataRelationshipsGroupDataType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionCreateRequestDataRelationshipsGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroups" => SubscriptionCreateRequestDataRelationshipsGroupDataType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}