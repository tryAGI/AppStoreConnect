
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode
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
    public static class SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode value)
        {
            return value switch
            {
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.Active => "active",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.AutoRenewEnabled => "autoRenewEnabled",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomCodes => "customCodes",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomerEligibilities => "customerEligibilities",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.Duration => "duration",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.Name => "name",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.NumberOfPeriods => "numberOfPeriods",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferEligibility => "offerEligibility",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferMode => "offerMode",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.Prices => "prices",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.ProductionCodeCount => "productionCodeCount",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.SandboxCodeCount => "sandboxCodeCount",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.Subscription => "subscription",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.TotalNumberOfCodes => "totalNumberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.Active,
                "autoRenewEnabled" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.AutoRenewEnabled,
                "customCodes" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomCodes,
                "customerEligibilities" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.CustomerEligibilities,
                "duration" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.Duration,
                "name" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.Name,
                "numberOfPeriods" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.NumberOfPeriods,
                "offerEligibility" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferEligibility,
                "offerMode" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.OfferMode,
                "oneTimeUseCodes" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.OneTimeUseCodes,
                "prices" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.Prices,
                "productionCodeCount" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.SandboxCodeCount,
                "subscription" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.Subscription,
                "targetSubscriptionPlanType" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.TargetSubscriptionPlanType,
                "totalNumberOfCodes" => SubscriptionOfferCodesOneTimeUseCodesGetToManyRelatedFieldsSubscriptionOfferCode.TotalNumberOfCodes,
                _ => null,
            };
        }
    }
}