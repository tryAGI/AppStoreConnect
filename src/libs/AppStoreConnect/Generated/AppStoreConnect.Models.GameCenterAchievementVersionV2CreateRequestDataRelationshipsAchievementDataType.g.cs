
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementVersionV2CreateRequestDataRelationshipsAchievementDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievements,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementVersionV2CreateRequestDataRelationshipsAchievementDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionV2CreateRequestDataRelationshipsAchievementDataType value)
        {
            return value switch
            {
                GameCenterAchievementVersionV2CreateRequestDataRelationshipsAchievementDataType.GameCenterAchievements => "gameCenterAchievements",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionV2CreateRequestDataRelationshipsAchievementDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievements" => GameCenterAchievementVersionV2CreateRequestDataRelationshipsAchievementDataType.GameCenterAchievements,
                _ => null,
            };
        }
    }
}