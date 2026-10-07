
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization
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
    public static class AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEvent => "appEvent",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Locale => "locale",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.LongDescription => "longDescription",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Name => "name",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Placements => "placements",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Locale,
                "longDescription" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.LongDescription,
                "name" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Name,
                "placements" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.Placements,
                "shortDescription" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}