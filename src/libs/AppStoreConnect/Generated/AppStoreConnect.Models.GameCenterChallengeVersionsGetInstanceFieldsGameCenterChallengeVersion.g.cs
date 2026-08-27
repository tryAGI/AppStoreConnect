
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion
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
    public static class GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion value)
        {
            return value switch
            {
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.Challenge => "challenge",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.DefaultImage => "defaultImage",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.Localizations => "localizations",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.Releases => "releases",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.State => "state",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.Challenge,
                "defaultImage" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.DefaultImage,
                "localizations" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.Localizations,
                "releases" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.Releases,
                "state" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.State,
                "version" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeVersion.Version,
                _ => null,
            };
        }
    }
}