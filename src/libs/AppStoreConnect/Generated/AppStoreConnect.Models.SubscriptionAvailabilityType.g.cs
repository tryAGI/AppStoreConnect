
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAvailabilityType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAvailabilityTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAvailabilityType value)
        {
            return value switch
            {
                SubscriptionAvailabilityType.SubscriptionAvailabilities => "subscriptionAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAvailabilityType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionAvailabilities" => SubscriptionAvailabilityType.SubscriptionAvailabilities,
                _ => null,
            };
        }
    }
}