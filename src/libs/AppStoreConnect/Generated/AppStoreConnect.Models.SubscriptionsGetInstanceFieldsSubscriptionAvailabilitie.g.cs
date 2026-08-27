
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie
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
    public static class SubscriptionsGetInstanceFieldsSubscriptionAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => SubscriptionsGetInstanceFieldsSubscriptionAvailabilitie.AvailableTerritories,
                _ => null,
            };
        }
    }
}