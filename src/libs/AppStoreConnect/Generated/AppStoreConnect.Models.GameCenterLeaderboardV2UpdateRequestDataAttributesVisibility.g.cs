
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardV2UpdateRequestDataAttributesVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        HideForAll,
        /// <summary>
        /// 
        /// </summary>
        ShowForAll,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterLeaderboardV2UpdateRequestDataAttributesVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2UpdateRequestDataAttributesVisibility value)
        {
            return value switch
            {
                GameCenterLeaderboardV2UpdateRequestDataAttributesVisibility.HideForAll => "HIDE_FOR_ALL",
                GameCenterLeaderboardV2UpdateRequestDataAttributesVisibility.ShowForAll => "SHOW_FOR_ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2UpdateRequestDataAttributesVisibility? ToEnum(string value)
        {
            return value switch
            {
                "HIDE_FOR_ALL" => GameCenterLeaderboardV2UpdateRequestDataAttributesVisibility.HideForAll,
                "SHOW_FOR_ALL" => GameCenterLeaderboardV2UpdateRequestDataAttributesVisibility.ShowForAll,
                _ => null,
            };
        }
    }
}