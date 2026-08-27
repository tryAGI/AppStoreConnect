
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization
    {
        /// <summary>
        ///
        /// </summary>
        Description,
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Version,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization value)
        {
            return value switch
            {
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization.Description => "description",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization.Image => "image",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization.Locale => "locale",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization.Name => "name",
                GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization.Description,
                "image" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization.Image,
                "locale" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization.Locale,
                "name" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization.Name,
                "version" => GameCenterChallengeVersionsLocalizationsGetToManyRelatedFieldsGameCenterChallengeLocalization.Version,
                _ => null,
            };
        }
    }
}