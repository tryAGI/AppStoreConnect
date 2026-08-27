
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterLeaderboardActivityLinkageRequestDataType
    {
        /// <summary>
        ///
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardActivityLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardActivityLinkageRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardActivityLinkageRequestDataType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardActivityLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterLeaderboardActivityLinkageRequestDataType.GameCenterActivities,
                _ => null,
            };
        }
    }
}