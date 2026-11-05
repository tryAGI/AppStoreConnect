
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization
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
    public static class RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization value)
        {
            return value switch
            {
                RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization.Body => "body",
                RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization.Header => "header",
                RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization.Locale => "locale",
                RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization.RetentionMessageVersion => "retentionMessageVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "body" => RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization.Body,
                "header" => RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization.Header,
                "locale" => RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization.Locale,
                "retentionMessageVersion" => RetentionMessageVersionsLocalizationsGetToManyRelatedFieldsRetentionMessageLocalization.RetentionMessageVersion,
                _ => null,
            };
        }
    }
}