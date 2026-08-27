
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion
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
    public static class GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion value)
        {
            return value switch
            {
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge => "challenge",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage => "defaultImage",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations => "localizations",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Releases => "releases",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.State => "state",
                GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge,
                "defaultImage" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage,
                "localizations" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations,
                "releases" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Releases,
                "state" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.State,
                "version" => GameCenterGroupsGameCenterChallengesGetToManyRelatedFieldsGameCenterChallengeVersion.Version,
                _ => null,
            };
        }
    }
}