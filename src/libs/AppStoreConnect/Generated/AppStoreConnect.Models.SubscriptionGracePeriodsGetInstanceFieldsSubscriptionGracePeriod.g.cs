
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod
    {
        /// <summary>
        /// 
        /// </summary>
        Duration,
        /// <summary>
        /// 
        /// </summary>
        OptIn,
        /// <summary>
        /// 
        /// </summary>
        RenewalType,
        /// <summary>
        /// 
        /// </summary>
        SandboxOptIn,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod value)
        {
            return value switch
            {
                SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod.Duration => "duration",
                SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod.OptIn => "optIn",
                SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod.RenewalType => "renewalType",
                SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod.SandboxOptIn => "sandboxOptIn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod? ToEnum(string value)
        {
            return value switch
            {
                "duration" => SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod.Duration,
                "optIn" => SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod.OptIn,
                "renewalType" => SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod.RenewalType,
                "sandboxOptIn" => SubscriptionGracePeriodsGetInstanceFieldsSubscriptionGracePeriod.SandboxOptIn,
                _ => null,
            };
        }
    }
}