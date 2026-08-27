
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie
    {
        /// <summary>
        /// 
        /// </summary>
        AvailableInNewTerritories,
        /// <summary>
        /// 
        /// </summary>
        AvailableTerritories,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie value)
        {
            return value switch
            {
                SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => SubscriptionsSubscriptionAvailabilityGetToOneRelatedFieldsSubscriptionAvailabilitie.AvailableTerritories,
                _ => null,
            };
        }
    }
}