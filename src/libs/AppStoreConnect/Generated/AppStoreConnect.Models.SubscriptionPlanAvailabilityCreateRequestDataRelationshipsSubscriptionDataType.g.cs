
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPlanAvailabilityCreateRequestDataRelationshipsSubscriptionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilityCreateRequestDataRelationshipsSubscriptionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilityCreateRequestDataRelationshipsSubscriptionDataType value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilityCreateRequestDataRelationshipsSubscriptionDataType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilityCreateRequestDataRelationshipsSubscriptionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => SubscriptionPlanAvailabilityCreateRequestDataRelationshipsSubscriptionDataType.Subscriptions,
                _ => null,
            };
        }
    }
}