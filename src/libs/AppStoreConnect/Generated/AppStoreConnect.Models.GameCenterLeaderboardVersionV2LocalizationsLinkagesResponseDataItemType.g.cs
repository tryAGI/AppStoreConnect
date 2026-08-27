
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardVersionV2LocalizationsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardVersionV2LocalizationsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardVersionV2LocalizationsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                GameCenterLeaderboardVersionV2LocalizationsLinkagesResponseDataItemType.GameCenterLeaderboardLocalizations => "gameCenterLeaderboardLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardVersionV2LocalizationsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardLocalizations" => GameCenterLeaderboardVersionV2LocalizationsLinkagesResponseDataItemType.GameCenterLeaderboardLocalizations,
                _ => null,
            };
        }
    }
}