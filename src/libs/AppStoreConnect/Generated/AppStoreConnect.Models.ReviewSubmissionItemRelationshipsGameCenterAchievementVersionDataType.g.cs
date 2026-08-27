
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementVersions" => ReviewSubmissionItemRelationshipsGameCenterAchievementVersionDataType.GameCenterAchievementVersions,
                _ => null,
            };
        }
    }
}