
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => ReviewSubmissionItemCreateRequestDataRelationshipsAppCustomProductPageVersionDataType.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}