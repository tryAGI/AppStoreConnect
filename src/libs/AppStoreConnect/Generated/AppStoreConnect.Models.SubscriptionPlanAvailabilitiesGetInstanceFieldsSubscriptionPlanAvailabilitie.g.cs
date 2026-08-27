
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie
    {
        /// <summary>
        ///
        /// </summary>
        AvailableInNewTerritories,
        /// <summary>
        ///
        /// </summary>
        AvailableTerritories,
        /// <summary>
        ///
        /// </summary>
        PlanType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie value)
        {
            return value switch
            {
                SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie.AvailableTerritories => "availableTerritories",
                SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie.PlanType => "planType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie.AvailableTerritories,
                "planType" => SubscriptionPlanAvailabilitiesGetInstanceFieldsSubscriptionPlanAvailabilitie.PlanType,
                _ => null,
            };
        }
    }
}