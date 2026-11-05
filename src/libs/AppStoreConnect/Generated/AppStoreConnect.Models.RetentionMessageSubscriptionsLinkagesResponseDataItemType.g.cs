
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageSubscriptionsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageSubscriptionsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageSubscriptionsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                RetentionMessageSubscriptionsLinkagesResponseDataItemType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageSubscriptionsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => RetentionMessageSubscriptionsLinkagesResponseDataItemType.Subscriptions,
                _ => null,
            };
        }
    }
}