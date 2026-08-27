
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetRelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType.GameCenterLeaderboardSetLocalizations => "gameCenterLeaderboardSetLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetLocalizations" => GameCenterLeaderboardSetRelationshipsLocalizationsDataItemType.GameCenterLeaderboardSetLocalizations,
                _ => null,
            };
        }
    }
}