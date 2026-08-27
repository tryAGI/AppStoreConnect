
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion
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
    public static class GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion value)
        {
            return value switch
            {
                GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge => "challenge",
                GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage => "defaultImage",
                GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations => "localizations",
                GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.Releases => "releases",
                GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.State => "state",
                GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge,
                "defaultImage" => GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage,
                "localizations" => GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations,
                "releases" => GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.Releases,
                "state" => GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.State,
                "version" => GameCenterDetailsChallengeReleasesGetToManyRelatedFieldsGameCenterChallengeVersion.Version,
                _ => null,
            };
        }
    }
}