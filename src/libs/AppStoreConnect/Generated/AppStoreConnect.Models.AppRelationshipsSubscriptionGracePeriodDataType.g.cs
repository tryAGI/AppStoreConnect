
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppRelationshipsSubscriptionGracePeriodDataType
    {
        /// <summary>
        /// 
        /// </summary>
        SubscriptionGracePeriods,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsSubscriptionGracePeriodDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsSubscriptionGracePeriodDataType value)
        {
            return value switch
            {
                AppRelationshipsSubscriptionGracePeriodDataType.SubscriptionGracePeriods => "subscriptionGracePeriods",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsSubscriptionGracePeriodDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptionGracePeriods" => AppRelationshipsSubscriptionGracePeriodDataType.SubscriptionGracePeriods,
                _ => null,
            };
        }
    }
}