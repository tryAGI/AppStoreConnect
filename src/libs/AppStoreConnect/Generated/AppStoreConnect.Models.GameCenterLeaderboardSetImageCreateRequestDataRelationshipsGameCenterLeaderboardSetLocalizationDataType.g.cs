
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetImageCreateRequestDataRelationshipsGameCenterLeaderboardSetLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetImageCreateRequestDataRelationshipsGameCenterLeaderboardSetLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImageCreateRequestDataRelationshipsGameCenterLeaderboardSetLocalizationDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImageCreateRequestDataRelationshipsGameCenterLeaderboardSetLocalizationDataType.GameCenterLeaderboardSetLocalizations => "gameCenterLeaderboardSetLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImageCreateRequestDataRelationshipsGameCenterLeaderboardSetLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetLocalizations" => GameCenterLeaderboardSetImageCreateRequestDataRelationshipsGameCenterLeaderboardSetLocalizationDataType.GameCenterLeaderboardSetLocalizations,
                _ => null,
            };
        }
    }
}