
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGracePeriodUpdateRequestDataAttributesRenewalType
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
    public static class SubscriptionGracePeriodUpdateRequestDataAttributesRenewalTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGracePeriodUpdateRequestDataAttributesRenewalType value)
        {
            return value switch
            {
                SubscriptionGracePeriodUpdateRequestDataAttributesRenewalType.AllRenewals => "ALL_RENEWALS",
                SubscriptionGracePeriodUpdateRequestDataAttributesRenewalType.PaidToPaidOnly => "PAID_TO_PAID_ONLY",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGracePeriodUpdateRequestDataAttributesRenewalType? ToEnum(string value)
        {
            return value switch
            {
                "ALL_RENEWALS" => SubscriptionGracePeriodUpdateRequestDataAttributesRenewalType.AllRenewals,
                "PAID_TO_PAID_ONLY" => SubscriptionGracePeriodUpdateRequestDataAttributesRenewalType.PaidToPaidOnly,
                _ => null,
            };
        }
    }
}