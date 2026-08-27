
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardImageRelationshipsGameCenterLeaderboardLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardImageRelationshipsGameCenterLeaderboardLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImageRelationshipsGameCenterLeaderboardLocalizationDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardImageRelationshipsGameCenterLeaderboardLocalizationDataType.GameCenterLeaderboardLocalizations => "gameCenterLeaderboardLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImageRelationshipsGameCenterLeaderboardLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardLocalizations" => GameCenterLeaderboardImageRelationshipsGameCenterLeaderboardLocalizationDataType.GameCenterLeaderboardLocalizations,
                _ => null,
            };
        }
    }
}