
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardV2CreateRequestDataAttributesVisibility
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
    public static class GameCenterLeaderboardV2CreateRequestDataAttributesVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardV2CreateRequestDataAttributesVisibility value)
        {
            return value switch
            {
                GameCenterLeaderboardV2CreateRequestDataAttributesVisibility.HideForAll => "HIDE_FOR_ALL",
                GameCenterLeaderboardV2CreateRequestDataAttributesVisibility.ShowForAll => "SHOW_FOR_ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardV2CreateRequestDataAttributesVisibility? ToEnum(string value)
        {
            return value switch
            {
                "HIDE_FOR_ALL" => GameCenterLeaderboardV2CreateRequestDataAttributesVisibility.HideForAll,
                "SHOW_FOR_ALL" => GameCenterLeaderboardV2CreateRequestDataAttributesVisibility.ShowForAll,
                _ => null,
            };
        }
    }
}