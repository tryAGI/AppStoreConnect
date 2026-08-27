
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardImageV2CreateRequestDataRelationshipsLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardImageV2CreateRequestDataRelationshipsLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImageV2CreateRequestDataRelationshipsLocalizationDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardImageV2CreateRequestDataRelationshipsLocalizationDataType.GameCenterLeaderboardLocalizations => "gameCenterLeaderboardLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImageV2CreateRequestDataRelationshipsLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardLocalizations" => GameCenterLeaderboardImageV2CreateRequestDataRelationshipsLocalizationDataType.GameCenterLeaderboardLocalizations,
                _ => null,
            };
        }
    }
}