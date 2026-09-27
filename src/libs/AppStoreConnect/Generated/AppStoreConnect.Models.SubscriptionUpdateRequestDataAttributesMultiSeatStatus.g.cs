
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionUpdateRequestDataAttributesMultiSeatStatus
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
    public static class SubscriptionUpdateRequestDataAttributesMultiSeatStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionUpdateRequestDataAttributesMultiSeatStatus value)
        {
            return value switch
            {
                SubscriptionUpdateRequestDataAttributesMultiSeatStatus.Disabled => "DISABLED",
                SubscriptionUpdateRequestDataAttributesMultiSeatStatus.Enabled => "ENABLED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionUpdateRequestDataAttributesMultiSeatStatus? ToEnum(string value)
        {
            return value switch
            {
                "DISABLED" => SubscriptionUpdateRequestDataAttributesMultiSeatStatus.Disabled,
                "ENABLED" => SubscriptionUpdateRequestDataAttributesMultiSeatStatus.Enabled,
                _ => null,
            };
        }
    }
}