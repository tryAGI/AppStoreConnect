
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPlanAvailabilityUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPlanAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilityUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilityUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilityUpdateRequestDataType.SubscriptionPlanAvailabilities => "subscriptionPlanAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilityUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPlanAvailabilities" => SubscriptionPlanAvailabilityUpdateRequestDataType.SubscriptionPlanAvailabilities,
                _ => null,
            };
        }
    }
}