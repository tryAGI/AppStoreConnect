
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardImageCreateRequestDataRelationshipsGameCenterLeaderboardLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardImageCreateRequestDataRelationshipsGameCenterLeaderboardLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardImageCreateRequestDataRelationshipsGameCenterLeaderboardLocalizationDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardImageCreateRequestDataRelationshipsGameCenterLeaderboardLocalizationDataType.GameCenterLeaderboardLocalizations => "gameCenterLeaderboardLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardImageCreateRequestDataRelationshipsGameCenterLeaderboardLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardLocalizations" => GameCenterLeaderboardImageCreateRequestDataRelationshipsGameCenterLeaderboardLocalizationDataType.GameCenterLeaderboardLocalizations,
                _ => null,
            };
        }
    }
}