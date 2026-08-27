
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardUpdateRequestDataAttributesVisibility
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
    public static class GameCenterLeaderboardUpdateRequestDataAttributesVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardUpdateRequestDataAttributesVisibility value)
        {
            return value switch
            {
                GameCenterLeaderboardUpdateRequestDataAttributesVisibility.HideForAll => "HIDE_FOR_ALL",
                GameCenterLeaderboardUpdateRequestDataAttributesVisibility.ShowForAll => "SHOW_FOR_ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardUpdateRequestDataAttributesVisibility? ToEnum(string value)
        {
            return value switch
            {
                "HIDE_FOR_ALL" => GameCenterLeaderboardUpdateRequestDataAttributesVisibility.HideForAll,
                "SHOW_FOR_ALL" => GameCenterLeaderboardUpdateRequestDataAttributesVisibility.ShowForAll,
                _ => null,
            };
        }
    }
}