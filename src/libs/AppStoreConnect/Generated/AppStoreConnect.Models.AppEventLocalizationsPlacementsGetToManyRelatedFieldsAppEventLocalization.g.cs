
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization
    {
        /// <summary>
        ///
        /// </summary>
        AppEvent,
        /// <summary>
        ///
        /// </summary>
        AppEventScreenshots,
        /// <summary>
        ///
        /// </summary>
        AppEventVideoClips,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        LongDescription,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Placements,
        /// <summary>
        ///
        /// </summary>
        ShortDescription,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEvent => "appEvent",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Locale => "locale",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.LongDescription => "longDescription",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Name => "name",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Placements => "placements",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Locale,
                "longDescription" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.LongDescription,
                "name" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Name,
                "placements" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Placements,
                "shortDescription" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}