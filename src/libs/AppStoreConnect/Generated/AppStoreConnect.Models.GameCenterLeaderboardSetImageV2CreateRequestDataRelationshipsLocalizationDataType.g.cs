
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetImageV2CreateRequestDataRelationshipsLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetImageV2CreateRequestDataRelationshipsLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImageV2CreateRequestDataRelationshipsLocalizationDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImageV2CreateRequestDataRelationshipsLocalizationDataType.GameCenterLeaderboardSetLocalizations => "gameCenterLeaderboardSetLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImageV2CreateRequestDataRelationshipsLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetLocalizations" => GameCenterLeaderboardSetImageV2CreateRequestDataRelationshipsLocalizationDataType.GameCenterLeaderboardSetLocalizations,
                _ => null,
            };
        }
    }
}