
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType.GameCenterLeaderboardSetLocalizations => "gameCenterLeaderboardSetLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetLocalizations" => GameCenterLeaderboardSetVersionV2RelationshipsLocalizationsDataItemType.GameCenterLeaderboardSetLocalizations,
                _ => null,
            };
        }
    }
}