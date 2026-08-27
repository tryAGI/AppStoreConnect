
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie
    {
        /// <summary>
        /// 
        /// </summary>
        Currency,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie value)
        {
            return value switch
            {
                SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie.Currency => "currency",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie? ToEnum(string value)
        {
            return value switch
            {
                "currency" => SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsTerritorie.Currency,
                _ => null,
            };
        }
    }
}