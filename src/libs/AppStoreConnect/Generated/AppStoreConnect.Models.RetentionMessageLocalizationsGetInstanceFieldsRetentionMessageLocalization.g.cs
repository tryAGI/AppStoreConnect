
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization
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
    public static class RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization value)
        {
            return value switch
            {
                RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization.Body => "body",
                RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization.Header => "header",
                RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization.Locale => "locale",
                RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization.RetentionMessageVersion => "retentionMessageVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "body" => RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization.Body,
                "header" => RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization.Header,
                "locale" => RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization.Locale,
                "retentionMessageVersion" => RetentionMessageLocalizationsGetInstanceFieldsRetentionMessageLocalization.RetentionMessageVersion,
                _ => null,
            };
        }
    }
}