
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetInstanceFieldsSubscriptionGracePeriod
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
    public static class AppsGetInstanceFieldsSubscriptionGracePeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsSubscriptionGracePeriod value)
        {
            return value switch
            {
                AppsGetInstanceFieldsSubscriptionGracePeriod.Duration => "duration",
                AppsGetInstanceFieldsSubscriptionGracePeriod.OptIn => "optIn",
                AppsGetInstanceFieldsSubscriptionGracePeriod.RenewalType => "renewalType",
                AppsGetInstanceFieldsSubscriptionGracePeriod.SandboxOptIn => "sandboxOptIn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsSubscriptionGracePeriod? ToEnum(string value)
        {
            return value switch
            {
                "duration" => AppsGetInstanceFieldsSubscriptionGracePeriod.Duration,
                "optIn" => AppsGetInstanceFieldsSubscriptionGracePeriod.OptIn,
                "renewalType" => AppsGetInstanceFieldsSubscriptionGracePeriod.RenewalType,
                "sandboxOptIn" => AppsGetInstanceFieldsSubscriptionGracePeriod.SandboxOptIn,
                _ => null,
            };
        }
    }
}