
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion
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
        /// <summary>
        /// 
        /// </summary>
        State,
        /// <summary>
        /// 
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion value)
        {
            return value switch
            {
                GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.Challenge => "challenge",
                GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.DefaultImage => "defaultImage",
                GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.Localizations => "localizations",
                GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.Releases => "releases",
                GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.State => "state",
                GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.Challenge,
                "defaultImage" => GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.DefaultImage,
                "localizations" => GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.Localizations,
                "releases" => GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.Releases,
                "state" => GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.State,
                "version" => GameCenterChallengeVersionReleasesGetInstanceFieldsGameCenterChallengeVersion.Version,
                _ => null,
            };
        }
    }
}