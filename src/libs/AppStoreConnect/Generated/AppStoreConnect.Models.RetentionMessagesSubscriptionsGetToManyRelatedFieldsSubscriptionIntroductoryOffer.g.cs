
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer
    {
        /// <summary>
        ///
        /// </summary>
        Duration,
        /// <summary>
        ///
        /// </summary>
        EndDate,
        /// <summary>
        ///
        /// </summary>
        NumberOfPeriods,
        /// <summary>
        ///
        /// </summary>
        OfferMode,
        /// <summary>
        ///
        /// </summary>
        StartDate,
        /// <summary>
        ///
        /// </summary>
        Subscription,
        /// <summary>
        ///
        /// </summary>
        SubscriptionPricePoint,
        /// <summary>
        ///
        /// </summary>
        TargetSubscriptionPlanType,
        /// <summary>
        ///
        /// </summary>
        Territory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOfferExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Duration => "duration",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.EndDate => "endDate",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.NumberOfPeriods => "numberOfPeriods",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.OfferMode => "offerMode",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.StartDate => "startDate",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Subscription => "subscription",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.SubscriptionPricePoint => "subscriptionPricePoint",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Territory => "territory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer? ToEnum(string value)
        {
            return value switch
            {
                "duration" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Duration,
                "endDate" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.EndDate,
                "numberOfPeriods" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.NumberOfPeriods,
                "offerMode" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.OfferMode,
                "startDate" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.StartDate,
                "subscription" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Subscription,
                "subscriptionPricePoint" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.SubscriptionPricePoint,
                "targetSubscriptionPlanType" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.TargetSubscriptionPlanType,
                "territory" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionIntroductoryOffer.Territory,
                _ => null,
            };
        }
    }
}