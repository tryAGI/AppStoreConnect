
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsRetentionMessagesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Subscriptions,
        /// <summary>
        ///
        /// </summary>
        Versions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsRetentionMessagesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsRetentionMessagesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsRetentionMessagesGetToManyRelatedIncludeItem.Subscriptions => "subscriptions",
                AppsRetentionMessagesGetToManyRelatedIncludeItem.Versions => "versions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsRetentionMessagesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "subscriptions" => AppsRetentionMessagesGetToManyRelatedIncludeItem.Subscriptions,
                "versions" => AppsRetentionMessagesGetToManyRelatedIncludeItem.Versions,
                _ => null,
            };
        }
    }
}