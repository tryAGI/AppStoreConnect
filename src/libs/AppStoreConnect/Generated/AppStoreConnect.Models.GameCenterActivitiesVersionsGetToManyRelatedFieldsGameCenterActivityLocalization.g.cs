
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization
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
    public static class GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization value)
        {
            return value switch
            {
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization.Description => "description",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization.Image => "image",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization.Locale => "locale",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization.Name => "name",
                GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization.Version => "version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization? ToEnum(string value)
        {
            return value switch
            {
                "description" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization.Description,
                "image" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization.Image,
                "locale" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization.Locale,
                "name" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization.Name,
                "version" => GameCenterActivitiesVersionsGetToManyRelatedFieldsGameCenterActivityLocalization.Version,
                _ => null,
            };
        }
    }
}