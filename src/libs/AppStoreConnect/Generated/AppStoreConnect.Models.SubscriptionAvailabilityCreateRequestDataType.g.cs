
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionAvailabilityCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAvailabilityCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAvailabilityCreateRequestDataType value)
        {
            return value switch
            {
                SubscriptionAvailabilityCreateRequestDataType.SubscriptionAvailabilities => "subscriptionAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAvailabilityCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionAvailabilities" => SubscriptionAvailabilityCreateRequestDataType.SubscriptionAvailabilities,
                _ => null,
            };
        }
    }
}