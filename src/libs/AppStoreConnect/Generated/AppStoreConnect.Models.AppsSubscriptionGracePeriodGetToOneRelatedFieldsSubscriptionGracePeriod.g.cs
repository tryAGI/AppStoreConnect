
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod
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
    public static class AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod value)
        {
            return value switch
            {
                AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod.Duration => "duration",
                AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod.OptIn => "optIn",
                AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod.RenewalType => "renewalType",
                AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod.SandboxOptIn => "sandboxOptIn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod? ToEnum(string value)
        {
            return value switch
            {
                "duration" => AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod.Duration,
                "optIn" => AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod.OptIn,
                "renewalType" => AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod.RenewalType,
                "sandboxOptIn" => AppsSubscriptionGracePeriodGetToOneRelatedFieldsSubscriptionGracePeriod.SandboxOptIn,
                _ => null,
            };
        }
    }
}