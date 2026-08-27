
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode
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
    public static class SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode value)
        {
            return value switch
            {
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.Active => "active",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.AutoRenewEnabled => "autoRenewEnabled",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomCodes => "customCodes",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomerEligibilities => "customerEligibilities",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.Duration => "duration",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.Name => "name",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.NumberOfPeriods => "numberOfPeriods",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferEligibility => "offerEligibility",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferMode => "offerMode",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.Prices => "prices",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.ProductionCodeCount => "productionCodeCount",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.SandboxCodeCount => "sandboxCodeCount",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.Subscription => "subscription",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.TotalNumberOfCodes => "totalNumberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.Active,
                "autoRenewEnabled" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.AutoRenewEnabled,
                "customCodes" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomCodes,
                "customerEligibilities" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomerEligibilities,
                "duration" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.Duration,
                "name" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.Name,
                "numberOfPeriods" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.NumberOfPeriods,
                "offerEligibility" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferEligibility,
                "offerMode" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferMode,
                "oneTimeUseCodes" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.OneTimeUseCodes,
                "prices" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.Prices,
                "productionCodeCount" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.SandboxCodeCount,
                "subscription" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.Subscription,
                "targetSubscriptionPlanType" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.TargetSubscriptionPlanType,
                "totalNumberOfCodes" => SubscriptionOfferCodesCustomCodesGetToManyRelatedFieldsSubscriptionOfferCode.TotalNumberOfCodes,
                _ => null,
            };
        }
    }
}