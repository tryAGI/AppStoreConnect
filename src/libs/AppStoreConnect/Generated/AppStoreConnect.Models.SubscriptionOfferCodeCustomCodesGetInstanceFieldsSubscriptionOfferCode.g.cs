
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode
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
    public static class SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode value)
        {
            return value switch
            {
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.Active => "active",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.AutoRenewEnabled => "autoRenewEnabled",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.CustomCodes => "customCodes",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.CustomerEligibilities => "customerEligibilities",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.Duration => "duration",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.Name => "name",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.NumberOfPeriods => "numberOfPeriods",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.OfferEligibility => "offerEligibility",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.OfferMode => "offerMode",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.Prices => "prices",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.ProductionCodeCount => "productionCodeCount",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.SandboxCodeCount => "sandboxCodeCount",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.Subscription => "subscription",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.TotalNumberOfCodes => "totalNumberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.Active,
                "autoRenewEnabled" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.AutoRenewEnabled,
                "customCodes" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.CustomCodes,
                "customerEligibilities" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.CustomerEligibilities,
                "duration" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.Duration,
                "name" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.Name,
                "numberOfPeriods" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.NumberOfPeriods,
                "offerEligibility" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.OfferEligibility,
                "offerMode" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.OfferMode,
                "oneTimeUseCodes" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.OneTimeUseCodes,
                "prices" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.Prices,
                "productionCodeCount" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.SandboxCodeCount,
                "subscription" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.Subscription,
                "targetSubscriptionPlanType" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.TargetSubscriptionPlanType,
                "totalNumberOfCodes" => SubscriptionOfferCodeCustomCodesGetInstanceFieldsSubscriptionOfferCode.TotalNumberOfCodes,
                _ => null,
            };
        }
    }
}