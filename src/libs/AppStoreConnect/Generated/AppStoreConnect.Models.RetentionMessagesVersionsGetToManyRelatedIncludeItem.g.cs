
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesVersionsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Localizations,
        /// <summary>
        ///
        /// </summary>
        Placement,
        /// <summary>
        ///
        /// </summary>
        RetentionMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesVersionsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesVersionsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                RetentionMessagesVersionsGetToManyRelatedIncludeItem.Localizations => "localizations",
                RetentionMessagesVersionsGetToManyRelatedIncludeItem.Placement => "placement",
                RetentionMessagesVersionsGetToManyRelatedIncludeItem.RetentionMessage => "retentionMessage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesVersionsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => RetentionMessagesVersionsGetToManyRelatedIncludeItem.Localizations,
                "placement" => RetentionMessagesVersionsGetToManyRelatedIncludeItem.Placement,
                "retentionMessage" => RetentionMessagesVersionsGetToManyRelatedIncludeItem.RetentionMessage,
                _ => null,
            };
        }
    }
}