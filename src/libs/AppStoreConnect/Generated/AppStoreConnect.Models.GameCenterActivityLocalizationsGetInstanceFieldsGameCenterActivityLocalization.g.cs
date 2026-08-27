
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization
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
    public static class GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization value)
        {
            return value switch
            {
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization.Description => "description",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization.Image => "image",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization.Locale => "locale",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization.Name => "name",
                GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization.Description,
                "image" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization.Image,
                "locale" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization.Locale,
                "name" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization.Name,
                "version" => GameCenterActivityLocalizationsGetInstanceFieldsGameCenterActivityLocalization.Version,
                _ => null,
            };
        }
    }
}