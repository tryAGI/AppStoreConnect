
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum SubscriptionCustomerEligibility
    {
        /// <summary>
        /// 
        /// </summary>
        Existing,
        /// <summary>
        /// 
        /// </summary>
        Expired,
        /// <summary>
        /// 
        /// </summary>
        New,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionCustomerEligibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionCustomerEligibility value)
        {
            return value switch
            {
                SubscriptionCustomerEligibility.Existing => "EXISTING",
                SubscriptionCustomerEligibility.Expired => "EXPIRED",
                SubscriptionCustomerEligibility.New => "NEW",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionCustomerEligibility? ToEnum(string value)
        {
            return value switch
            {
                "EXISTING" => SubscriptionCustomerEligibility.Existing,
                "EXPIRED" => SubscriptionCustomerEligibility.Expired,
                "NEW" => SubscriptionCustomerEligibility.New,
                _ => null,
            };
        }
    }
}