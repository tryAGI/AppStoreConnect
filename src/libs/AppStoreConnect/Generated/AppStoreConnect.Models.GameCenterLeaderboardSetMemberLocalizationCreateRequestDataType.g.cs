
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetMemberLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetMemberLocalizationCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationCreateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationCreateRequestDataType.GameCenterLeaderboardSetMemberLocalizations => "gameCenterLeaderboardSetMemberLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetMemberLocalizations" => GameCenterLeaderboardSetMemberLocalizationCreateRequestDataType.GameCenterLeaderboardSetMemberLocalizations,
                _ => null,
            };
        }
    }
}