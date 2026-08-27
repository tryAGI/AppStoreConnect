
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode
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
    public static class SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode value)
        {
            return value switch
            {
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.Active => "active",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.AutoRenewEnabled => "autoRenewEnabled",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.CustomCodes => "customCodes",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.CustomerEligibilities => "customerEligibilities",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.Duration => "duration",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.Name => "name",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.NumberOfPeriods => "numberOfPeriods",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.OfferEligibility => "offerEligibility",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.OfferMode => "offerMode",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.Prices => "prices",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.ProductionCodeCount => "productionCodeCount",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.SandboxCodeCount => "sandboxCodeCount",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.Subscription => "subscription",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.TotalNumberOfCodes => "totalNumberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.Active,
                "autoRenewEnabled" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.AutoRenewEnabled,
                "customCodes" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.CustomCodes,
                "customerEligibilities" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.CustomerEligibilities,
                "duration" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.Duration,
                "name" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.Name,
                "numberOfPeriods" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.NumberOfPeriods,
                "offerEligibility" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.OfferEligibility,
                "offerMode" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.OfferMode,
                "oneTimeUseCodes" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.OneTimeUseCodes,
                "prices" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.Prices,
                "productionCodeCount" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.SandboxCodeCount,
                "subscription" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.Subscription,
                "targetSubscriptionPlanType" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.TargetSubscriptionPlanType,
                "totalNumberOfCodes" => SubscriptionOfferCodesGetInstanceFieldsSubscriptionOfferCode.TotalNumberOfCodes,
                _ => null,
            };
        }
    }
}