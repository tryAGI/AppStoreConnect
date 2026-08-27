
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterAchievementLocalizationV2CreateRequestDataRelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterAchievementVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterAchievementLocalizationV2CreateRequestDataRelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAchievementLocalizationV2CreateRequestDataRelationshipsVersionDataType value)
        {
            return value switch
            {
                GameCenterAchievementLocalizationV2CreateRequestDataRelationshipsVersionDataType.GameCenterAchievementVersions => "gameCenterAchievementVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAchievementLocalizationV2CreateRequestDataRelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterAchievementVersions" => GameCenterAchievementLocalizationV2CreateRequestDataRelationshipsVersionDataType.GameCenterAchievementVersions,
                _ => null,
            };
        }
    }
}