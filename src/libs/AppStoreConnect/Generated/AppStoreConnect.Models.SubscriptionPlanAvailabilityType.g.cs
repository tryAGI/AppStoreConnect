
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPlanAvailabilityType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionPlanAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilityType value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilityType.SubscriptionPlanAvailabilities => "subscriptionPlanAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilityType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionPlanAvailabilities" => SubscriptionPlanAvailabilityType.SubscriptionPlanAvailabilities,
                _ => null,
            };
        }
    }
}