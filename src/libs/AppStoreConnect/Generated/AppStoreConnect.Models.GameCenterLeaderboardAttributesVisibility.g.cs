
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardAttributesVisibility
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
    public static class GameCenterLeaderboardAttributesVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardAttributesVisibility value)
        {
            return value switch
            {
                GameCenterLeaderboardAttributesVisibility.HideForAll => "HIDE_FOR_ALL",
                GameCenterLeaderboardAttributesVisibility.ShowForAll => "SHOW_FOR_ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardAttributesVisibility? ToEnum(string value)
        {
            return value switch
            {
                "HIDE_FOR_ALL" => GameCenterLeaderboardAttributesVisibility.HideForAll,
                "SHOW_FOR_ALL" => GameCenterLeaderboardAttributesVisibility.ShowForAll,
                _ => null,
            };
        }
    }
}