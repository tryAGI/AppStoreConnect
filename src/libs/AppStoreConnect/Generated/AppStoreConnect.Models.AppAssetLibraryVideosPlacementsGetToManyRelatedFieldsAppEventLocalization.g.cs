
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization
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
    public static class AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEvent => "appEvent",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.Locale => "locale",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.LongDescription => "longDescription",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.Name => "name",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.Placements => "placements",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.Locale,
                "longDescription" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.LongDescription,
                "name" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.Name,
                "placements" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.Placements,
                "shortDescription" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}