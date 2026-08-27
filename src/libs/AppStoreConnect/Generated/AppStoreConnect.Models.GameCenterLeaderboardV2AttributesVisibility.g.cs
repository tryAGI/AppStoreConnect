
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardV2AttributesVisibility
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
    public static class GameCenterLeaderboardV2AttributesVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2AttributesVisibility value)
        {
            return value switch
            {
                GameCenterLeaderboardV2AttributesVisibility.HideForAll => "HIDE_FOR_ALL",
                GameCenterLeaderboardV2AttributesVisibility.ShowForAll => "SHOW_FOR_ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2AttributesVisibility? ToEnum(string value)
        {
            return value switch
            {
                "HIDE_FOR_ALL" => GameCenterLeaderboardV2AttributesVisibility.HideForAll,
                "SHOW_FOR_ALL" => GameCenterLeaderboardV2AttributesVisibility.ShowForAll,
                _ => null,
            };
        }
    }
}