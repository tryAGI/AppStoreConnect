
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization
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
    public static class AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEvent => "appEvent",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Locale => "locale",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.LongDescription => "longDescription",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Name => "name",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Placements => "placements",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Locale,
                "longDescription" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.LongDescription,
                "name" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Name,
                "placements" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Placements,
                "shortDescription" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}