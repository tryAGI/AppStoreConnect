
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType.GameCenterLeaderboardSetVersions => "gameCenterLeaderboardSetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetVersions" => ReviewSubmissionItemRelationshipsGameCenterLeaderboardSetVersionDataType.GameCenterLeaderboardSetVersions,
                _ => null,
            };
        }
    }
}