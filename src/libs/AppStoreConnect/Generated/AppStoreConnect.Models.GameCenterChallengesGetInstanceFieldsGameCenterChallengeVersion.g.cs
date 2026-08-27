
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion
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
    public static class GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion value)
        {
            return value switch
            {
                GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.Challenge => "challenge",
                GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.DefaultImage => "defaultImage",
                GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.Localizations => "localizations",
                GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.Releases => "releases",
                GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.State => "state",
                GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.Challenge,
                "defaultImage" => GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.DefaultImage,
                "localizations" => GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.Localizations,
                "releases" => GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.Releases,
                "state" => GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.State,
                "version" => GameCenterChallengesGetInstanceFieldsGameCenterChallengeVersion.Version,
                _ => null,
            };
        }
    }
}