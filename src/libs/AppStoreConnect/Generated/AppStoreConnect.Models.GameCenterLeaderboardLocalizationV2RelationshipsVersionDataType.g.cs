
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationV2RelationshipsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType.GameCenterLeaderboardVersions => "gameCenterLeaderboardVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardVersions" => GameCenterLeaderboardLocalizationV2RelationshipsVersionDataType.GameCenterLeaderboardVersions,
                _ => null,
            };
        }
    }
}