
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion
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
    public static class GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion value)
        {
            return value switch
            {
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge => "challenge",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage => "defaultImage",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations => "localizations",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.Releases => "releases",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.State => "state",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge,
                "defaultImage" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage,
                "localizations" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations,
                "releases" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.Releases,
                "state" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.State,
                "version" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeVersion.Version,
                _ => null,
            };
        }
    }
}