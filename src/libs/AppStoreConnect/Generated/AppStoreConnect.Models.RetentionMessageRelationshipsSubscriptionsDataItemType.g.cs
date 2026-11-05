
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageRelationshipsSubscriptionsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageRelationshipsSubscriptionsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageRelationshipsSubscriptionsDataItemType value)
        {
            return value switch
            {
                RetentionMessageRelationshipsSubscriptionsDataItemType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageRelationshipsSubscriptionsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => RetentionMessageRelationshipsSubscriptionsDataItemType.Subscriptions,
                _ => null,
            };
        }
    }
}