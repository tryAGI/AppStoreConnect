
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationV2RelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationV2RelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationV2RelationshipsVersionDataType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationV2RelationshipsVersionDataType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationV2RelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementVersions" => GameCenterAchievementLocalizationV2RelationshipsVersionDataType.GameCenterAchievementVersions,
                _ => null,
            };
        }
    }
}