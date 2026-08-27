
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem
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
    public static class GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem.Image => "image",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "image" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem.Image,
                "version" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedIncludeItem.Version,
                _ => null,
            };
        }
    }
}