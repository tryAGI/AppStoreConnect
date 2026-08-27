
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType.GameCenterLeaderboardVersions => "gameCenterLeaderboardVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardVersions" => ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardVersionDataType.GameCenterLeaderboardVersions,
                _ => null,
            };
        }
    }
}