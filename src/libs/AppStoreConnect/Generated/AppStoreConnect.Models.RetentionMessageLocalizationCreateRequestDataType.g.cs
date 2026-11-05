
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageLocalizationCreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                RetentionMessageLocalizationCreateRequestDataType.RetentionMessageLocalizations => "retentionMessageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageLocalizations" => RetentionMessageLocalizationCreateRequestDataType.RetentionMessageLocalizations,
                _ => null,
            };
        }
    }
}