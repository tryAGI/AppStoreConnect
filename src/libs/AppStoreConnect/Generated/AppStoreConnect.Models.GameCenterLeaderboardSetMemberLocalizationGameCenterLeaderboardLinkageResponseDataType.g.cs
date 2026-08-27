
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardSetMemberLocalizationGameCenterLeaderboardLinkageResponseDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterLeaderboards,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetMemberLocalizationGameCenterLeaderboardLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetMemberLocalizationGameCenterLeaderboardLinkageResponseDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetMemberLocalizationGameCenterLeaderboardLinkageResponseDataType.GameCenterLeaderboards => "gameCenterLeaderboards",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetMemberLocalizationGameCenterLeaderboardLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboards" => GameCenterLeaderboardSetMemberLocalizationGameCenterLeaderboardLinkageResponseDataType.GameCenterLeaderboards,
                _ => null,
            };
        }
    }
}