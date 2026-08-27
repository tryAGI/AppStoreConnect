
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SandboxTesterV2AttributesSubscriptionRenewalRate
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
    public static class SandboxTesterV2AttributesSubscriptionRenewalRateExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SandboxTesterV2AttributesSubscriptionRenewalRate value)
        {
            return value switch
            {
                SandboxTesterV2AttributesSubscriptionRenewalRate.MonthlyRenewalEveryFifteenMinutes => "MONTHLY_RENEWAL_EVERY_FIFTEEN_MINUTES",
                SandboxTesterV2AttributesSubscriptionRenewalRate.MonthlyRenewalEveryFiveMinutes => "MONTHLY_RENEWAL_EVERY_FIVE_MINUTES",
                SandboxTesterV2AttributesSubscriptionRenewalRate.MonthlyRenewalEveryOneHour => "MONTHLY_RENEWAL_EVERY_ONE_HOUR",
                SandboxTesterV2AttributesSubscriptionRenewalRate.MonthlyRenewalEveryThirtyMinutes => "MONTHLY_RENEWAL_EVERY_THIRTY_MINUTES",
                SandboxTesterV2AttributesSubscriptionRenewalRate.MonthlyRenewalEveryThreeMinutes => "MONTHLY_RENEWAL_EVERY_THREE_MINUTES",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SandboxTesterV2AttributesSubscriptionRenewalRate? ToEnum(string value)
        {
            return value switch
            {
                "MONTHLY_RENEWAL_EVERY_FIFTEEN_MINUTES" => SandboxTesterV2AttributesSubscriptionRenewalRate.MonthlyRenewalEveryFifteenMinutes,
                "MONTHLY_RENEWAL_EVERY_FIVE_MINUTES" => SandboxTesterV2AttributesSubscriptionRenewalRate.MonthlyRenewalEveryFiveMinutes,
                "MONTHLY_RENEWAL_EVERY_ONE_HOUR" => SandboxTesterV2AttributesSubscriptionRenewalRate.MonthlyRenewalEveryOneHour,
                "MONTHLY_RENEWAL_EVERY_THIRTY_MINUTES" => SandboxTesterV2AttributesSubscriptionRenewalRate.MonthlyRenewalEveryThirtyMinutes,
                "MONTHLY_RENEWAL_EVERY_THREE_MINUTES" => SandboxTesterV2AttributesSubscriptionRenewalRate.MonthlyRenewalEveryThreeMinutes,
                _ => null,
            };
        }
    }
}