
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "version" => GameCenterDetailsChallengeReleasesGetToManyRelatedIncludeItem.Version,
                _ => null,
            };
        }
    }
}