
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageLocalizationType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageLocalizationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageLocalizationType value)
        {
            return value switch
            {
                RetentionMessageLocalizationType.RetentionMessageLocalizations => "retentionMessageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageLocalizationType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageLocalizations" => RetentionMessageLocalizationType.RetentionMessageLocalizations,
                _ => null,
            };
        }
    }
}