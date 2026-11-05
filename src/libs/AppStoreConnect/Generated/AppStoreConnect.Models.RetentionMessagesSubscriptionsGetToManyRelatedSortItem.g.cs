
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesSubscriptionsGetToManyRelatedSortItem
    {
        /// <summary>
        ///
        /// </summary>
        Minusname,
        /// <summary>
        ///
        /// </summary>
        Name,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesSubscriptionsGetToManyRelatedSortItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesSubscriptionsGetToManyRelatedSortItem value)
        {
            return value switch
            {
                RetentionMessagesSubscriptionsGetToManyRelatedSortItem.Minusname => "-name",
                RetentionMessagesSubscriptionsGetToManyRelatedSortItem.Name => "name",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesSubscriptionsGetToManyRelatedSortItem? ToEnum(string value)
        {
            return value switch
            {
                "-name" => RetentionMessagesSubscriptionsGetToManyRelatedSortItem.Minusname,
                "name" => RetentionMessagesSubscriptionsGetToManyRelatedSortItem.Name,
                _ => null,
            };
        }
    }
}