
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod
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
    public static class CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriodExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod.Duration => "duration",
                CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod.OptIn => "optIn",
                CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod.RenewalType => "renewalType",
                CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod.SandboxOptIn => "sandboxOptIn",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod? ToEnum(string value)
        {
            return value switch
            {
                "duration" => CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod.Duration,
                "optIn" => CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod.OptIn,
                "renewalType" => CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod.RenewalType,
                "sandboxOptIn" => CiProductsAppGetToOneRelatedFieldsSubscriptionGracePeriod.SandboxOptIn,
                _ => null,
            };
        }
    }
}