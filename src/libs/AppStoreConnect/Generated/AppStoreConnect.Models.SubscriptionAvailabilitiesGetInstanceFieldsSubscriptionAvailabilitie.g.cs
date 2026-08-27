
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitie
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
    public static class SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitie value)
        {
            return value switch
            {
                SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitie.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => SubscriptionAvailabilitiesGetInstanceFieldsSubscriptionAvailabilitie.AvailableTerritories,
                _ => null,
            };
        }
    }
}