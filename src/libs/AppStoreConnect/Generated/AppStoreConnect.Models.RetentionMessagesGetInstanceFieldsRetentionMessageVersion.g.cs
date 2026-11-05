
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesGetInstanceFieldsRetentionMessageVersion
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
        /// <summary>
        ///
        /// </summary>
        State,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesGetInstanceFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesGetInstanceFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                RetentionMessagesGetInstanceFieldsRetentionMessageVersion.Localizations => "localizations",
                RetentionMessagesGetInstanceFieldsRetentionMessageVersion.Placement => "placement",
                RetentionMessagesGetInstanceFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                RetentionMessagesGetInstanceFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesGetInstanceFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => RetentionMessagesGetInstanceFieldsRetentionMessageVersion.Localizations,
                "placement" => RetentionMessagesGetInstanceFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => RetentionMessagesGetInstanceFieldsRetentionMessageVersion.RetentionMessage,
                "state" => RetentionMessagesGetInstanceFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}