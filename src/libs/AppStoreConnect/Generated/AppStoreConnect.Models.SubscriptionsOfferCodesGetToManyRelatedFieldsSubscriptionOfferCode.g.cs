
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode
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
    public static class SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode value)
        {
            return value switch
            {
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.Active => "active",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.AutoRenewEnabled => "autoRenewEnabled",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomCodes => "customCodes",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomerEligibilities => "customerEligibilities",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.Duration => "duration",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.Name => "name",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.NumberOfPeriods => "numberOfPeriods",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferEligibility => "offerEligibility",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferMode => "offerMode",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.Prices => "prices",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.ProductionCodeCount => "productionCodeCount",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.SandboxCodeCount => "sandboxCodeCount",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.Subscription => "subscription",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.TotalNumberOfCodes => "totalNumberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.Active,
                "autoRenewEnabled" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.AutoRenewEnabled,
                "customCodes" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomCodes,
                "customerEligibilities" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomerEligibilities,
                "duration" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.Duration,
                "name" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.Name,
                "numberOfPeriods" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.NumberOfPeriods,
                "offerEligibility" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferEligibility,
                "offerMode" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferMode,
                "oneTimeUseCodes" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.OneTimeUseCodes,
                "prices" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.Prices,
                "productionCodeCount" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.SandboxCodeCount,
                "subscription" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.Subscription,
                "targetSubscriptionPlanType" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.TargetSubscriptionPlanType,
                "totalNumberOfCodes" => SubscriptionsOfferCodesGetToManyRelatedFieldsSubscriptionOfferCode.TotalNumberOfCodes,
                _ => null,
            };
        }
    }
}