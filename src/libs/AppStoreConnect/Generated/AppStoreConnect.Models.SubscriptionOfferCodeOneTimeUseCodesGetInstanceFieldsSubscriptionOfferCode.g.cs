
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode
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
    public static class SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode value)
        {
            return value switch
            {
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.Active => "active",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.AutoRenewEnabled => "autoRenewEnabled",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.CustomCodes => "customCodes",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.CustomerEligibilities => "customerEligibilities",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.Duration => "duration",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.Name => "name",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.NumberOfPeriods => "numberOfPeriods",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.OfferEligibility => "offerEligibility",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.OfferMode => "offerMode",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.Prices => "prices",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.ProductionCodeCount => "productionCodeCount",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.SandboxCodeCount => "sandboxCodeCount",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.Subscription => "subscription",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.TotalNumberOfCodes => "totalNumberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.Active,
                "autoRenewEnabled" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.AutoRenewEnabled,
                "customCodes" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.CustomCodes,
                "customerEligibilities" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.CustomerEligibilities,
                "duration" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.Duration,
                "name" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.Name,
                "numberOfPeriods" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.NumberOfPeriods,
                "offerEligibility" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.OfferEligibility,
                "offerMode" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.OfferMode,
                "oneTimeUseCodes" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.OneTimeUseCodes,
                "prices" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.Prices,
                "productionCodeCount" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.SandboxCodeCount,
                "subscription" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.Subscription,
                "targetSubscriptionPlanType" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.TargetSubscriptionPlanType,
                "totalNumberOfCodes" => SubscriptionOfferCodeOneTimeUseCodesGetInstanceFieldsSubscriptionOfferCode.TotalNumberOfCodes,
                _ => null,
            };
        }
    }
}