
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionReleasesGetInstanceIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionReleasesGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionReleasesGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterChallengeVersionReleasesGetInstanceIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionReleasesGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterChallengeVersionReleasesGetInstanceIncludeItem.Version,
                _ => null,
            };
        }
    }
}