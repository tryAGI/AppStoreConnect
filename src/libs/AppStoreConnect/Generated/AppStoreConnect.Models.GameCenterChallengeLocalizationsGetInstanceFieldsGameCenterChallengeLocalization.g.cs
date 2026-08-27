
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization
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
    public static class GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization value)
        {
            return value switch
            {
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization.Description => "description",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization.Image => "image",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization.Locale => "locale",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization.Name => "name",
                GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization.Description,
                "image" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization.Image,
                "locale" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization.Locale,
                "name" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization.Name,
                "version" => GameCenterChallengeLocalizationsGetInstanceFieldsGameCenterChallengeLocalization.Version,
                _ => null,
            };
        }
    }
}