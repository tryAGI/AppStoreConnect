
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsAppStoreVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsAppStoreVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsAppStoreVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsAppStoreVersionDataType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsAppStoreVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersions" => ReviewSubmissionItemRelationshipsAppStoreVersionDataType.AppStoreVersions,
                _ => null,
            };
        }
    }
}