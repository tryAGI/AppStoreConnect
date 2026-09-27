
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionAttributesMultiSeatStatus
    {
        /// <summary>
        ///
        /// </summary>
        Disabled,
        /// <summary>
        ///
        /// </summary>
        Enabled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionAttributesMultiSeatStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionAttributesMultiSeatStatus value)
        {
            return value switch
            {
                SubscriptionAttributesMultiSeatStatus.Disabled => "DISABLED",
                SubscriptionAttributesMultiSeatStatus.Enabled => "ENABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionAttributesMultiSeatStatus? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => SubscriptionAttributesMultiSeatStatus.Disabled,
                "ENABLED" => SubscriptionAttributesMultiSeatStatus.Enabled,
                _ => null,
            };
        }
    }
}