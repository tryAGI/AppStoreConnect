
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionRelationshipsSubscriptionAvailabilityDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionAvailabilities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionRelationshipsSubscriptionAvailabilityDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionRelationshipsSubscriptionAvailabilityDataType value)
        {
            return value switch
            {
                SubscriptionRelationshipsSubscriptionAvailabilityDataType.SubscriptionAvailabilities => "subscriptionAvailabilities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionRelationshipsSubscriptionAvailabilityDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionAvailabilities" => SubscriptionRelationshipsSubscriptionAvailabilityDataType.SubscriptionAvailabilities,
                _ => null,
            };
        }
    }
}