
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie
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
    public static class SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie.AvailableTerritories => "availableTerritories",
                SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie.PlanType => "planType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie.AvailableTerritories,
                "planType" => SubscriptionsGetInstanceFieldsSubscriptionPlanAvailabilitie.PlanType,
                _ => null,
            };
        }
    }
}