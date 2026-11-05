
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice
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
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPriceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.PlanType => "planType",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.Preserved => "preserved",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.StartDate => "startDate",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.SubscriptionPricePoint => "subscriptionPricePoint",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice? ToEnum(string value)
        {
            return value switch
            {
                "planType" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.PlanType,
                "preserved" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.Preserved,
                "startDate" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.StartDate,
                "subscriptionPricePoint" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.SubscriptionPricePoint,
                "territory" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPrice.Territory,
                _ => null,
            };
        }
    }
}