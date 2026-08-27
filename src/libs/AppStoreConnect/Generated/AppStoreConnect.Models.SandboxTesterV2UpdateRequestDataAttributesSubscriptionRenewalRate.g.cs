
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate
    {
        /// <summary>
        /// 
        /// </summary>
        MonthlyRenewalEveryFifteenMinutes,
        /// <summary>
        /// 
        /// </summary>
        MonthlyRenewalEveryFiveMinutes,
        /// <summary>
        /// 
        /// </summary>
        MonthlyRenewalEveryOneHour,
        /// <summary>
        /// 
        /// </summary>
        MonthlyRenewalEveryThirtyMinutes,
        /// <summary>
        /// 
        /// </summary>
        MonthlyRenewalEveryThreeMinutes,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate value)
        {
            return value switch
            {
                SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate.MonthlyRenewalEveryFifteenMinutes => "MONTHLY_RENEWAL_EVERY_FIFTEEN_MINUTES",
                SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate.MonthlyRenewalEveryFiveMinutes => "MONTHLY_RENEWAL_EVERY_FIVE_MINUTES",
                SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate.MonthlyRenewalEveryOneHour => "MONTHLY_RENEWAL_EVERY_ONE_HOUR",
                SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate.MonthlyRenewalEveryThirtyMinutes => "MONTHLY_RENEWAL_EVERY_THIRTY_MINUTES",
                SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate.MonthlyRenewalEveryThreeMinutes => "MONTHLY_RENEWAL_EVERY_THREE_MINUTES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate? ToEnum(string value)
        {
            return value switch
            {
                "MONTHLY_RENEWAL_EVERY_FIFTEEN_MINUTES" => SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate.MonthlyRenewalEveryFifteenMinutes,
                "MONTHLY_RENEWAL_EVERY_FIVE_MINUTES" => SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate.MonthlyRenewalEveryFiveMinutes,
                "MONTHLY_RENEWAL_EVERY_ONE_HOUR" => SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate.MonthlyRenewalEveryOneHour,
                "MONTHLY_RENEWAL_EVERY_THIRTY_MINUTES" => SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate.MonthlyRenewalEveryThirtyMinutes,
                "MONTHLY_RENEWAL_EVERY_THREE_MINUTES" => SandboxTesterV2UpdateRequestDataAttributesSubscriptionRenewalRate.MonthlyRenewalEveryThreeMinutes,
                _ => null,
            };
        }
    }
}