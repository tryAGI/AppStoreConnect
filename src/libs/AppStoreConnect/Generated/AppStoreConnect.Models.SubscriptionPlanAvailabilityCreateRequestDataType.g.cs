
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionPlanAvailabilityCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionPlanAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilityCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilityCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilityCreateRequestDataType.SubscriptionPlanAvailabilities => "subscriptionPlanAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilityCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPlanAvailabilities" => SubscriptionPlanAvailabilityCreateRequestDataType.SubscriptionPlanAvailabilities,
                _ => null,
            };
        }
    }
}