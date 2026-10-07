
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization
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
    public static class AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEvent => "appEvent",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.Locale => "locale",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.LongDescription => "longDescription",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.Name => "name",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.Placements => "placements",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.Locale,
                "longDescription" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.LongDescription,
                "name" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.Name,
                "placements" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.Placements,
                "shortDescription" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}