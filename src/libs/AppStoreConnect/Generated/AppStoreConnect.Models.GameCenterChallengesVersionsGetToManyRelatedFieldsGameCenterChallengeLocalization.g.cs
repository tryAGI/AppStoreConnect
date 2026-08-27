
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization
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
    public static class GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization value)
        {
            return value switch
            {
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization.Description => "description",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization.Image => "image",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization.Locale => "locale",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization.Name => "name",
                GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization.Description,
                "image" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization.Image,
                "locale" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization.Locale,
                "name" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization.Name,
                "version" => GameCenterChallengesVersionsGetToManyRelatedFieldsGameCenterChallengeLocalization.Version,
                _ => null,
            };
        }
    }
}