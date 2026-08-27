
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AvailableTerritories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem value)
        {
            return value switch
            {
                SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "availableTerritories" => SubscriptionsSubscriptionAvailabilityGetToOneRelatedIncludeItem.AvailableTerritories,
                _ => null,
            };
        }
    }
}