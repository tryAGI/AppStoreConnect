
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion
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
    public static class RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion value)
        {
            return value switch
            {
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion.Localizations => "localizations",
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion.Placement => "placement",
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage => "retentionMessage",
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion.State => "state",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion? ToEnum(string value)
        {
            return value switch
            {
                "localizations" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion.Localizations,
                "placement" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion.Placement,
                "retentionMessage" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion.RetentionMessage,
                "state" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageVersion.State,
                _ => null,
            };
        }
    }
}