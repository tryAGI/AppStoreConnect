
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization
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
    public static class GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization value)
        {
            return value switch
            {
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization.Description => "description",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization.Image => "image",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization.Locale => "locale",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization.Name => "name",
                GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization.Description,
                "image" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization.Image,
                "locale" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization.Locale,
                "name" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization.Name,
                "version" => GameCenterChallengeVersionsGetInstanceFieldsGameCenterChallengeLocalization.Version,
                _ => null,
            };
        }
    }
}