
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum RetentionMessageLocalizationCreateRequestDataRelationshipsRetentionMessageVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RetentionMessageLocalizationCreateRequestDataRelationshipsRetentionMessageVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RetentionMessageLocalizationCreateRequestDataRelationshipsRetentionMessageVersionDataType value)
        {
            return value switch
            {
                RetentionMessageLocalizationCreateRequestDataRelationshipsRetentionMessageVersionDataType.RetentionMessageVersions => "retentionMessageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RetentionMessageLocalizationCreateRequestDataRelationshipsRetentionMessageVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersions" => RetentionMessageLocalizationCreateRequestDataRelationshipsRetentionMessageVersionDataType.RetentionMessageVersions,
                _ => null,
            };
        }
    }
}