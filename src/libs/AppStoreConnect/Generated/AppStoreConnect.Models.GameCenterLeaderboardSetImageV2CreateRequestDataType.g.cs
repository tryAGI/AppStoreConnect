
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardSetImageV2CreateRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterLeaderboardSetImages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardSetImageV2CreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardSetImageV2CreateRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardSetImageV2CreateRequestDataType.GameCenterLeaderboardSetImages => "gameCenterLeaderboardSetImages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardSetImageV2CreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterLeaderboardSetImages" => GameCenterLeaderboardSetImageV2CreateRequestDataType.GameCenterLeaderboardSetImages,
                _ => null,
            };
        }
    }
}