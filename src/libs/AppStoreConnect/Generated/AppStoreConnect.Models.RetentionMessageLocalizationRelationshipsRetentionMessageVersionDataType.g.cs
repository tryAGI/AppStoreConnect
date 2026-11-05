
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageLocalizationRelationshipsRetentionMessageVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageLocalizationRelationshipsRetentionMessageVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageLocalizationRelationshipsRetentionMessageVersionDataType value)
        {
            return value switch
            {
                RetentionMessageLocalizationRelationshipsRetentionMessageVersionDataType.RetentionMessageVersions => "retentionMessageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageLocalizationRelationshipsRetentionMessageVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersions" => RetentionMessageLocalizationRelationshipsRetentionMessageVersionDataType.RetentionMessageVersions,
                _ => null,
            };
        }
    }
}