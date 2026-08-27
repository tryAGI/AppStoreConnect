
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterLeaderboardCreateRequestDataAttributesVisibility
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
    public static class GameCenterLeaderboardCreateRequestDataAttributesVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterLeaderboardCreateRequestDataAttributesVisibility value)
        {
            return value switch
            {
                GameCenterLeaderboardCreateRequestDataAttributesVisibility.HideForAll => "HIDE_FOR_ALL",
                GameCenterLeaderboardCreateRequestDataAttributesVisibility.ShowForAll => "SHOW_FOR_ALL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterLeaderboardCreateRequestDataAttributesVisibility? ToEnum(string value)
        {
            return value switch
            {
                "HIDE_FOR_ALL" => GameCenterLeaderboardCreateRequestDataAttributesVisibility.HideForAll,
                "SHOW_FOR_ALL" => GameCenterLeaderboardCreateRequestDataAttributesVisibility.ShowForAll,
                _ => null,
            };
        }
    }
}