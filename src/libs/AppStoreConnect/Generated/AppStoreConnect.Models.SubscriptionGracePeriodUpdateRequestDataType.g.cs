
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGracePeriodUpdateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGracePeriods,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGracePeriodUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGracePeriodUpdateRequestDataType value)
        {
            return value switch
            {
                SubscriptionGracePeriodUpdateRequestDataType.SubscriptionGracePeriods => "subscriptionGracePeriods",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGracePeriodUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGracePeriods" => SubscriptionGracePeriodUpdateRequestDataType.SubscriptionGracePeriods,
                _ => null,
            };
        }
    }
}