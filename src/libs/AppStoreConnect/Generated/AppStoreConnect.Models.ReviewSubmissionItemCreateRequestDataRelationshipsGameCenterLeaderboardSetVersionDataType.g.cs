
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType.GameCenterLeaderboardSetVersions => "gameCenterLeaderboardSetVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetVersions" => ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterLeaderboardSetVersionDataType.GameCenterLeaderboardSetVersions,
                _ => null,
            };
        }
    }
}