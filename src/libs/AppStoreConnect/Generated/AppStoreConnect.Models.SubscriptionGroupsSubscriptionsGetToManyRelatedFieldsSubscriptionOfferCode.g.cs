
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode
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
    public static class SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode value)
        {
            return value switch
            {
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Active => "active",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.AutoRenewEnabled => "autoRenewEnabled",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.CustomCodes => "customCodes",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.CustomerEligibilities => "customerEligibilities",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Duration => "duration",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Name => "name",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.NumberOfPeriods => "numberOfPeriods",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OfferEligibility => "offerEligibility",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OfferMode => "offerMode",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OneTimeUseCodes => "oneTimeUseCodes",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Prices => "prices",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.ProductionCodeCount => "productionCodeCount",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.SandboxCodeCount => "sandboxCodeCount",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Subscription => "subscription",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.TargetSubscriptionPlanType => "targetSubscriptionPlanType",
                SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.TotalNumberOfCodes => "totalNumberOfCodes",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode? ToEnum(string value)
        {
            return value switch
            {
                "active" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Active,
                "autoRenewEnabled" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.AutoRenewEnabled,
                "customCodes" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.CustomCodes,
                "customerEligibilities" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.CustomerEligibilities,
                "duration" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Duration,
                "name" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Name,
                "numberOfPeriods" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.NumberOfPeriods,
                "offerEligibility" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OfferEligibility,
                "offerMode" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OfferMode,
                "oneTimeUseCodes" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.OneTimeUseCodes,
                "prices" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Prices,
                "productionCodeCount" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.ProductionCodeCount,
                "sandboxCodeCount" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.SandboxCodeCount,
                "subscription" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.Subscription,
                "targetSubscriptionPlanType" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.TargetSubscriptionPlanType,
                "totalNumberOfCodes" => SubscriptionGroupsSubscriptionsGetToManyRelatedFieldsSubscriptionOfferCode.TotalNumberOfCodes,
                _ => null,
            };
        }
    }
}