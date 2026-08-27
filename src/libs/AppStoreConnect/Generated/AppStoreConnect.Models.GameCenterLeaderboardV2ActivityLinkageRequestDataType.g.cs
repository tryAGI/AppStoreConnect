
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardV2ActivityLinkageRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        GameCenterActivities,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardV2ActivityLinkageRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2ActivityLinkageRequestDataType value)
        {
            return value switch
            {
                GameCenterLeaderboardV2ActivityLinkageRequestDataType.GameCenterActivities => "gameCenterActivities",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2ActivityLinkageRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "gameCenterActivities" => GameCenterLeaderboardV2ActivityLinkageRequestDataType.GameCenterActivities,
                _ => null,
            };
        }
    }
}