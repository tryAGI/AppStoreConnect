
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionGracePeriodAttributesRenewalType
    {
        /// <summary>
        /// 
        /// </summary>
        AllRenewals,
        /// <summary>
        /// 
        /// </summary>
        PaidToPaidOnly,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGracePeriodAttributesRenewalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGracePeriodAttributesRenewalType value)
        {
            return value switch
            {
                SubscriptionGracePeriodAttributesRenewalType.AllRenewals => "ALL_RENEWALS",
                SubscriptionGracePeriodAttributesRenewalType.PaidToPaidOnly => "PAID_TO_PAID_ONLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGracePeriodAttributesRenewalType? ToEnum(string value)
        {
            return value switch
            {
                "ALL_RENEWALS" => SubscriptionGracePeriodAttributesRenewalType.AllRenewals,
                "PAID_TO_PAID_ONLY" => SubscriptionGracePeriodAttributesRenewalType.PaidToPaidOnly,
                _ => null,
            };
        }
    }
}