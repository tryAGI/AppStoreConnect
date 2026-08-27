
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterLeaderboardLocalizationRelationshipsGameCenterLeaderboardDataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}