
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionGracePeriodDuration
    {
        /// <summary>
        ///
        /// </summary>
        SixteenDays,
        /// <summary>
        ///
        /// </summary>
        ThreeDays,
        /// <summary>
        ///
        /// </summary>
        TwentyEightDays,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionGracePeriodDurationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionGracePeriodDuration value)
        {
            return value switch
            {
                SubscriptionGracePeriodDuration.SixteenDays => "SIXTEEN_DAYS",
                SubscriptionGracePeriodDuration.ThreeDays => "THREE_DAYS",
                SubscriptionGracePeriodDuration.TwentyEightDays => "TWENTY_EIGHT_DAYS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionGracePeriodDuration? ToEnum(string value)
        {
            return value switch
            {
                "SIXTEEN_DAYS" => SubscriptionGracePeriodDuration.SixteenDays,
                "THREE_DAYS" => SubscriptionGracePeriodDuration.ThreeDays,
                "TWENTY_EIGHT_DAYS" => SubscriptionGracePeriodDuration.TwentyEightDays,
                _ => null,
            };
        }
    }
}