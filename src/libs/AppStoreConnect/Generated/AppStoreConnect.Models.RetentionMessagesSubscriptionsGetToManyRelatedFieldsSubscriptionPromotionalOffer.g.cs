
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer
    {
        /// <summary>
        ///
        /// </summary>
        Duration,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        NumberOfPeriods,
        /// <summary>
        ///
        /// </summary>
        OfferCode,
        /// <summary>
        ///
        /// </summary>
        OfferMode,
        /// <summary>
        ///
        /// </summary>
        Prices,
        /// <summary>
        ///
        /// </summary>
        Subscription,
        /// <summary>
        ///
        /// </summary>
        TargetSubscriptionPlanType,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Duration => "duration",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Name => "name",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.NumberOfPeriods => "numberOfPeriods",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferCode => "offerCode",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferMode => "offerMode",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Prices => "prices",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Subscription => "subscription",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer? ToEnum(string value)
        {
            return value switch
            {
                "duration" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Duration,
                "name" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Name,
                "numberOfPeriods" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.NumberOfPeriods,
                "offerCode" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferCode,
                "offerMode" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.OfferMode,
                "prices" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Prices,
                "subscription" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.Subscription,
                "targetSubscriptionPlanType" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionPromotionalOffer.TargetSubscriptionPlanType,
                _ => null,
            };
        }
    }
}