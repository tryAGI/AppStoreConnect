
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization
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
    public static class RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization value)
        {
            return value switch
            {
                RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization.Body => "body",
                RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization.Header => "header",
                RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization.Locale => "locale",
                RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization.RetentionMessageVersion => "retentionMessageVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "body" => RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization.Body,
                "header" => RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization.Header,
                "locale" => RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization.Locale,
                "retentionMessageVersion" => RetentionMessageVersionsGetInstanceFieldsRetentionMessageLocalization.RetentionMessageVersion,
                _ => null,
            };
        }
    }
}