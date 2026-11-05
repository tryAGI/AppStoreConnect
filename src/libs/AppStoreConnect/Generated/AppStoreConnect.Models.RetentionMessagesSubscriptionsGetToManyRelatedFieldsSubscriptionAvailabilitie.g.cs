
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitieExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie.AvailableInNewTerritories => "availableInNewTerritories",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie.AvailableTerritories => "availableTerritories",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie? ToEnum(string value)
        {
            return value switch
            {
                "availableInNewTerritories" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie.AvailableInNewTerritories,
                "availableTerritories" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionAvailabilitie.AvailableTerritories,
                _ => null,
            };
        }
    }
}