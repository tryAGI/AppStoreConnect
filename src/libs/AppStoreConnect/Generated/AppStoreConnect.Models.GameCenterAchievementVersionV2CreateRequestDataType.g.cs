
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementVersionV2CreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementVersionV2CreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementVersionV2CreateRequestDataType value)
        {
            return value switch
            {
                GameCenterAchievementVersionV2CreateRequestDataType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementVersionV2CreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementVersions" => GameCenterAchievementVersionV2CreateRequestDataType.GameCenterAchievementVersions,
                _ => null,
            };
        }
    }
}