
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterAchievementVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType value)
        {
            return value switch
            {
                ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementVersions" => ReviewSubmissionItemCreateRequestDataRelationshipsGameCenterAchievementVersionDataType.GameCenterAchievementVersions,
                _ => null,
            };
        }
    }
}