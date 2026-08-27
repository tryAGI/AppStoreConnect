
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppSubscriptionGracePeriodLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        SubscriptionGracePeriods,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppSubscriptionGracePeriodLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppSubscriptionGracePeriodLinkageResponseDataType value)
        {
            return value switch
            {
                AppSubscriptionGracePeriodLinkageResponseDataType.SubscriptionGracePeriods => "subscriptionGracePeriods",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppSubscriptionGracePeriodLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGracePeriods" => AppSubscriptionGracePeriodLinkageResponseDataType.SubscriptionGracePeriods,
                _ => null,
            };
        }
    }
}