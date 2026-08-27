
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion
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
    public static class GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion value)
        {
            return value switch
            {
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge => "challenge",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage => "defaultImage",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations => "localizations",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Releases => "releases",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.State => "state",
                GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge,
                "defaultImage" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage,
                "localizations" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations,
                "releases" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Releases,
                "state" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.State,
                "version" => GameCenterDetailsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Version,
                _ => null,
            };
        }
    }
}