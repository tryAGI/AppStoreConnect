
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsRetentionMessageVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        RetentionMessageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsRetentionMessageVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsRetentionMessageVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsRetentionMessageVersionDataType.RetentionMessageVersions => "retentionMessageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsRetentionMessageVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "retentionMessageVersions" => ReviewSubmissionItemRelationshipsRetentionMessageVersionDataType.RetentionMessageVersions,
                _ => null,
            };
        }
    }
}