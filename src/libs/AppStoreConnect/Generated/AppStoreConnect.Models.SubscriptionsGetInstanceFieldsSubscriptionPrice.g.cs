
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscriptionPrice
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
    public static class SubscriptionsGetInstanceFieldsSubscriptionPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscriptionPrice value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscriptionPrice.PlanType => "planType",
                SubscriptionsGetInstanceFieldsSubscriptionPrice.Preserved => "preserved",
                SubscriptionsGetInstanceFieldsSubscriptionPrice.StartDate => "startDate",
                SubscriptionsGetInstanceFieldsSubscriptionPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                SubscriptionsGetInstanceFieldsSubscriptionPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscriptionPrice? ToEnum(string value)
        {
            return value switch
            {
                "planType" => SubscriptionsGetInstanceFieldsSubscriptionPrice.PlanType,
                "preserved" => SubscriptionsGetInstanceFieldsSubscriptionPrice.Preserved,
                "startDate" => SubscriptionsGetInstanceFieldsSubscriptionPrice.StartDate,
                "subscriptionPricePoint" => SubscriptionsGetInstanceFieldsSubscriptionPrice.SubscriptionPricePoint,
                "territory" => SubscriptionsGetInstanceFieldsSubscriptionPrice.Territory,
                _ => null,
            };
        }
    }
}