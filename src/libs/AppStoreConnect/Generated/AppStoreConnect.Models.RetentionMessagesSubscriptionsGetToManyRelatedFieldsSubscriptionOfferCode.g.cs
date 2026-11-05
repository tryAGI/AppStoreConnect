
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode
    {
        /// <summary>
        ///
        /// </summary>
        Active,
        /// <summary>
        ///
        /// </summary>
        AutoRenewEnabled,
        /// <summary>
        ///
        /// </summary>
        CustomCodes,
        /// <summary>
        ///
        /// </summary>
        CustomerEligibilities,
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
        OfferEligibility,
        /// <summary>
        ///
        /// </summary>
        OfferMode,
        /// <summary>
        ///
        /// </summary>
        OneTimeUseCodes,
        /// <summary>
        ///
        /// </summary>
        Prices,
        /// <summary>
        ///
        /// </summary>
        ProductionCodeCount,
        /// <summary>
        ///
        /// </summary>
        SandboxCodeCount,
        /// <summary>
        ///
        /// </summary>
        Subscription,
        /// <summary>
        ///
        /// </summary>
        TargetSubscriptionPlanType,
        /// <summary>
        ///
        /// </summary>
        TotalNumberOfCodes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Active => "active",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.AutoRenewEnabled => "autoRenewEnabled",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.CustomCodes => "customCodes",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.CustomerEligibilities => "customerEligibilities",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Duration => "duration",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Name => "name",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.NumberOfPeriods => "numberOfPeriods",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OfferEligibility => "offerEligibility",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OfferMode => "offerMode",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Prices => "prices",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.ProductionCodeCount => "productionCodeCount",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.SandboxCodeCount => "sandboxCodeCount",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Subscription => "subscription",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.TotalNumberOfCodes => "totalNumberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Active,
                "autoRenewEnabled" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.AutoRenewEnabled,
                "customCodes" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.CustomCodes,
                "customerEligibilities" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.CustomerEligibilities,
                "duration" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Duration,
                "name" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Name,
                "numberOfPeriods" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.NumberOfPeriods,
                "offerEligibility" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OfferEligibility,
                "offerMode" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OfferMode,
                "oneTimeUseCodes" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OneTimeUseCodes,
                "prices" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Prices,
                "productionCodeCount" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.SandboxCodeCount,
                "subscription" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Subscription,
                "targetSubscriptionPlanType" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.TargetSubscriptionPlanType,
                "totalNumberOfCodes" => RetentionMessagesSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.TotalNumberOfCodes,
                _ => null,
            };
        }
    }
}