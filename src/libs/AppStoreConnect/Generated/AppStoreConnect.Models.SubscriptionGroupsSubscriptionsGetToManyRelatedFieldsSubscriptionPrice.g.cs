
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice
    {
        /// <summary>
        ///
        /// </summary>
        PlanType,
        /// <summary>
        ///
        /// </summary>
        Preserved,
        /// <summary>
        ///
        /// </summary>
        StartDate,
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoint,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.PlanType => "planType",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.Preserved => "preserved",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.StartDate => "startDate",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice? ToEnum(string value)
        {
            return value switch
            {
                "planType" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.PlanType,
                "preserved" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.Preserved,
                "startDate" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.StartDate,
                "subscriptionPricePoint" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.SubscriptionPricePoint,
                "territory" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.Territory,
                _ => null,
            };
        }
    }
}