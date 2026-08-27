
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType.GameCenterLeaderboardSetLocalizations => "gameCenterLeaderboardSetLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetLocalizations" => GameCenterLeaderboardSetImageRelationshipsGameCenterLeaderboardSetLocalizationDataType.GameCenterLeaderboardSetLocalizations,
                _ => null,
            };
        }
    }
}