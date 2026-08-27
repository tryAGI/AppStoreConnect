
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization
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
    public static class GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization value)
        {
            return value switch
            {
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization.Description => "description",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization.Image => "image",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization.Locale => "locale",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization.Name => "name",
                GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization.Description,
                "image" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization.Image,
                "locale" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization.Locale,
                "name" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization.Name,
                "version" => GameCenterActivityVersionsLocalizationsGetToManyRelatedFieldsGameCenterActivityLocalization.Version,
                _ => null,
            };
        }
    }
}