
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetVersionV2LocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetVersionV2LocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetVersionV2LocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetVersionV2LocalizationsLinkagesResponseDataItemType.GameCenterLeaderboardSetLocalizations => "gameCenterLeaderboardSetLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetVersionV2LocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetLocalizations" => GameCenterLeaderboardSetVersionV2LocalizationsLinkagesResponseDataItemType.GameCenterLeaderboardSetLocalizations,
                _ => null,
            };
        }
    }
}