
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableTerritories => "availableTerritories",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.PlanType => "planType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.AvailableTerritories,
                "planType" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPlanAvailabilitie.PlanType,
                _ => null,
            };
        }
    }
}