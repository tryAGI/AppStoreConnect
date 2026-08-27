
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie
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
    public static class SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie value)
        {
            return value switch
            {
                SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableTerritories => "availableTerritories",
                SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.PlanType => "planType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableTerritories,
                "planType" => SubscriptionsPlanAvailabilitiesGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.PlanType,
                _ => null,
            };
        }
    }
}