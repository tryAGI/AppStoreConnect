
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGracePeriodType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGracePeriods,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGracePeriodTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGracePeriodType value)
        {
            return value switch
            {
                SubscriptionGracePeriodType.SubscriptionGracePeriods => "subscriptionGracePeriods",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGracePeriodType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGracePeriods" => SubscriptionGracePeriodType.SubscriptionGracePeriods,
                _ => null,
            };
        }
    }
}