
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => ReviewSubmissionItemRelationshipsAppCustomProductPageVersionDataType.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}