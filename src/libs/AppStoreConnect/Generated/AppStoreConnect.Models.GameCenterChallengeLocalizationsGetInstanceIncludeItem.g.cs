
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeLocalizationsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeLocalizationsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationsGetInstanceIncludeItem.Image => "image",
                GameCenterChallengeLocalizationsGetInstanceIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterChallengeLocalizationsGetInstanceIncludeItem.Image,
                "version" => GameCenterChallengeLocalizationsGetInstanceIncludeItem.Version,
                _ => null,
            };
        }
    }
}