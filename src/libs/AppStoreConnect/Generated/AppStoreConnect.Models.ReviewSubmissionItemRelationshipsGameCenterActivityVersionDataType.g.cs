
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivityVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType.GameCenterActivityVersions => "gameCenterActivityVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivityVersions" => ReviewSubmissionItemRelationshipsGameCenterActivityVersionDataType.GameCenterActivityVersions,
                _ => null,
            };
        }
    }
}