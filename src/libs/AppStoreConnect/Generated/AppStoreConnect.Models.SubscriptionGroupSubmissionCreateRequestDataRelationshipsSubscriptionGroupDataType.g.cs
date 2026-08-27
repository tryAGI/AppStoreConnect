
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGroupSubmissionCreateRequestDataRelationshipsSubscriptionGroupDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGroups,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupSubmissionCreateRequestDataRelationshipsSubscriptionGroupDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupSubmissionCreateRequestDataRelationshipsSubscriptionGroupDataType value)
        {
            return value switch
            {
                SubscriptionGroupSubmissionCreateRequestDataRelationshipsSubscriptionGroupDataType.SubscriptionGroups => "subscriptionGroups",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupSubmissionCreateRequestDataRelationshipsSubscriptionGroupDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGroups" => SubscriptionGroupSubmissionCreateRequestDataRelationshipsSubscriptionGroupDataType.SubscriptionGroups,
                _ => null,
            };
        }
    }
}