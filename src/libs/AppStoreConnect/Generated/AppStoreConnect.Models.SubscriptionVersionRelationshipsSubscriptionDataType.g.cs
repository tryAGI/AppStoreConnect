
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum SubscriptionVersionRelationshipsSubscriptionDataType
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SubscriptionVersionRelationshipsSubscriptionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SubscriptionVersionRelationshipsSubscriptionDataType value)
        {
            return value switch
            {
                SubscriptionVersionRelationshipsSubscriptionDataType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SubscriptionVersionRelationshipsSubscriptionDataType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => SubscriptionVersionRelationshipsSubscriptionDataType.Subscriptions,
                _ => null,
            };
        }
    }
}