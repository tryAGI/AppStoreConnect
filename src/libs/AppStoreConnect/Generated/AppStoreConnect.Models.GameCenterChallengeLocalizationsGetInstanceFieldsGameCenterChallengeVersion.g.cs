
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion
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
    public static class GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.Challenge => "challenge",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.DefaultImage => "defaultImage",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.Localizations => "localizations",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.Releases => "releases",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.State => "state",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.Challenge,
                "defaultImage" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.DefaultImage,
                "localizations" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.Localizations,
                "releases" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.Releases,
                "state" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.State,
                "version" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeVersion.Version,
                _ => null,
            };
        }
    }
}