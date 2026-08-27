
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion
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
    public static class GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion value)
        {
            return value switch
            {
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge => "challenge",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage => "defaultImage",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations => "localizations",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.Releases => "releases",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.State => "state",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion? ToEnum(string value)
        {
            return value switch
            {
                "challenge" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.Challenge,
                "defaultImage" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.DefaultImage,
                "localizations" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.Localizations,
                "releases" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.Releases,
                "state" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.State,
                "version" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeVersion.Version,
                _ => null,
            };
        }
    }
}