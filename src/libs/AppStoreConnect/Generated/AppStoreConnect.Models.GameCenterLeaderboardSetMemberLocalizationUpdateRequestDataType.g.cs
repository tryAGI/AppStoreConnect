
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboardSetMemberLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetMemberLocalizationUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationUpdateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationUpdateRequestDataType.GameCenterLeaderboardSetMemberLocalizations => "gameCenterLeaderboardSetMemberLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetMemberLocalizations" => GameCenterLeaderboardSetMemberLocalizationUpdateRequestDataType.GameCenterLeaderboardSetMemberLocalizations,
                _ => null,
            };
        }
    }
}