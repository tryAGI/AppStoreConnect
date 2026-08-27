
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionSubscriptionAvailabilityLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionSubscriptionAvailabilityLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionSubscriptionAvailabilityLinkageResponseDataType value)
        {
            return value switch
            {
                SubscriptionSubscriptionAvailabilityLinkageResponseDataType.SubscriptionAvailabilities => "subscriptionAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionSubscriptionAvailabilityLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionAvailabilities" => SubscriptionSubscriptionAvailabilityLinkageResponseDataType.SubscriptionAvailabilities,
                _ => null,
            };
        }
    }
}