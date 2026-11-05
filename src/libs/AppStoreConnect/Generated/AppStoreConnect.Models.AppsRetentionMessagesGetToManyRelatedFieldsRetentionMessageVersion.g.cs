
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion
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
    public static class AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion.Placement => "placement",
                AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => AppsRetentionMessagesGetToManyRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}