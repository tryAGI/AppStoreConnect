
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization
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
    public static class GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization value)
        {
            return value switch
            {
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization.Description => "description",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization.Image => "image",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization.Locale => "locale",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization.Name => "name",
                GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization.Description,
                "image" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization.Image,
                "locale" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization.Locale,
                "name" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization.Name,
                "version" => GameCenterActivityVersionsGetInstanceFieldsGameCenterActivityLocalization.Version,
                _ => null,
            };
        }
    }
}