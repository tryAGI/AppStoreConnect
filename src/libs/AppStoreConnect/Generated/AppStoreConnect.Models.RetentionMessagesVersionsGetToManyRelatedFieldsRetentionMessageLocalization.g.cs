
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization
    {
        /// <summary>
        ///
        /// </summary>
        Body,
        /// <summary>
        ///
        /// </summary>
        Header,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization value)
        {
            return value switch
            {
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization.Body => "body",
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization.Header => "header",
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization.Locale => "locale",
                RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization.RetentionMessageVersion => "retentionMessageVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "body" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization.Body,
                "header" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization.Header,
                "locale" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization.Locale,
                "retentionMessageVersion" => RetentionMessagesVersionsGetToManyRelatedFieldsRetentionMessageLocalization.RetentionMessageVersion,
                _ => null,
            };
        }
    }
}