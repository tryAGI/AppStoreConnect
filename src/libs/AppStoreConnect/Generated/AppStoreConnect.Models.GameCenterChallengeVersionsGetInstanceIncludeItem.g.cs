
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        Challenge,
        /// <summary>
        /// 
        /// </summary>
        DefaultImage,
        /// <summary>
        /// 
        /// </summary>
        Localizations,
        /// <summary>
        /// 
        /// </summary>
        Releases,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsGetInstanceIncludeItem value)
        {
            return value switch
            {
                GameCenterChallengeVersionsGetInstanceIncludeItem.Challenge => "challenge",
                GameCenterChallengeVersionsGetInstanceIncludeItem.DefaultImage => "defaultImage",
                GameCenterChallengeVersionsGetInstanceIncludeItem.Localizations => "localizations",
                GameCenterChallengeVersionsGetInstanceIncludeItem.Releases => "releases",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterChallengeVersionsGetInstanceIncludeItem.Challenge,
                "defaultImage" => GameCenterChallengeVersionsGetInstanceIncludeItem.DefaultImage,
                "localizations" => GameCenterChallengeVersionsGetInstanceIncludeItem.Localizations,
                "releases" => GameCenterChallengeVersionsGetInstanceIncludeItem.Releases,
                _ => null,
            };
        }
    }
}