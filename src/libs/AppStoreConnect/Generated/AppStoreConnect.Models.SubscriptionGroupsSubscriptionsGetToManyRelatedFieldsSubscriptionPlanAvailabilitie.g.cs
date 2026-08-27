
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableTerritories => "availableTerritories",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.PlanType => "planType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableTerritories,
                "planType" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.PlanType,
                _ => null,
            };
        }
    }
}