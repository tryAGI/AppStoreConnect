
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie.AvailableTerritories,
                _ => null,
            };
        }
    }
}