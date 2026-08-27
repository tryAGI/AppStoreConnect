
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionPlanType
    {
        /// <summary>
        ///
        /// </summary>
        Monthly,
        /// <summary>
        ///
        /// </summary>
        Upfront,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionPlanType value)
        {
            return value switch
            {
                SubscriptionPlanType.Monthly => "MONTHLY",
                SubscriptionPlanType.Upfront => "UPFRONT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionPlanType? ToEnum(string value)
        {
            return value switch
            {
                "MONTHLY" => SubscriptionPlanType.Monthly,
                "UPFRONT" => SubscriptionPlanType.Upfront,
                _ => null,
            };
        }
    }
}