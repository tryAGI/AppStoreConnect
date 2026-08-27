
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetCollectionFieldsSubscriptionGracePeriod
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
    public static class AppsGetCollectionFieldsSubscriptionGracePeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsSubscriptionGracePeriod value)
        {
            return value switch
            {
                AppsGetCollectionFieldsSubscriptionGracePeriod.Duration => "duration",
                AppsGetCollectionFieldsSubscriptionGracePeriod.OptIn => "optIn",
                AppsGetCollectionFieldsSubscriptionGracePeriod.RenewalType => "renewalType",
                AppsGetCollectionFieldsSubscriptionGracePeriod.SandboxOptIn => "sandboxOptIn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsSubscriptionGracePeriod? ToEnum(string value)
        {
            return value switch
            {
                "duration" => AppsGetCollectionFieldsSubscriptionGracePeriod.Duration,
                "optIn" => AppsGetCollectionFieldsSubscriptionGracePeriod.OptIn,
                "renewalType" => AppsGetCollectionFieldsSubscriptionGracePeriod.RenewalType,
                "sandboxOptIn" => AppsGetCollectionFieldsSubscriptionGracePeriod.SandboxOptIn,
                _ => null,
            };
        }
    }
}