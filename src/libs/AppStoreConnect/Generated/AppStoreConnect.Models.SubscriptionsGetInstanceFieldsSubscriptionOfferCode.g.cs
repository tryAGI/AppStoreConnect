
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionsGetInstanceFieldsSubscriptionOfferCode
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
    public static class SubscriptionsGetInstanceFieldsSubscriptionOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionsGetInstanceFieldsSubscriptionOfferCode value)
        {
            return value switch
            {
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.Active => "active",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.AutoRenewEnabled => "autoRenewEnabled",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.CustomCodes => "customCodes",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.CustomerEligibilities => "customerEligibilities",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.Duration => "duration",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.Name => "name",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.NumberOfPeriods => "numberOfPeriods",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.OfferEligibility => "offerEligibility",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.OfferMode => "offerMode",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.Prices => "prices",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.ProductionCodeCount => "productionCodeCount",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.SandboxCodeCount => "sandboxCodeCount",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.Subscription => "subscription",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionsGetInstanceFieldsSubscriptionOfferCode.TotalNumberOfCodes => "totalNumberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionsGetInstanceFieldsSubscriptionOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.Active,
                "autoRenewEnabled" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.AutoRenewEnabled,
                "customCodes" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.CustomCodes,
                "customerEligibilities" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.CustomerEligibilities,
                "duration" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.Duration,
                "name" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.Name,
                "numberOfPeriods" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.NumberOfPeriods,
                "offerEligibility" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.OfferEligibility,
                "offerMode" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.OfferMode,
                "oneTimeUseCodes" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.OneTimeUseCodes,
                "prices" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.Prices,
                "productionCodeCount" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.SandboxCodeCount,
                "subscription" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.Subscription,
                "targetSubscriptionPlanType" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.TargetSubscriptionPlanType,
                "totalNumberOfCodes" => SubscriptionsGetInstanceFieldsSubscriptionOfferCode.TotalNumberOfCodes,
                _ => null,
            };
        }
    }
}