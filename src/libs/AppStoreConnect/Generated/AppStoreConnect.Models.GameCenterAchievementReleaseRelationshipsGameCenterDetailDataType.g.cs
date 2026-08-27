
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterDetails,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementReleaseRelationshipsGameCenterDetailDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType value)
        {
            return value switch
            {
                GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType.GameCenterDetails => "gameCenterDetails",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterDetails" => GameCenterAchievementReleaseRelationshipsGameCenterDetailDataType.GameCenterDetails,
                _ => null,
            };
        }
    }
}