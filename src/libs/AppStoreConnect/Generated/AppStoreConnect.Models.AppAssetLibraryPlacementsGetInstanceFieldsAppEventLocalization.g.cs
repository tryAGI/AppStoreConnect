
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization
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
    public static class AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization value)
        {
            return value switch
            {
                AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.AppEvent => "appEvent",
                AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.AppEventScreenshots => "appEventScreenshots",
                AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.AppEventVideoClips => "appEventVideoClips",
                AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.Locale => "locale",
                AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.LongDescription => "longDescription",
                AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.Name => "name",
                AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.Placements => "placements",
                AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.ShortDescription => "shortDescription",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appEvent" => AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.AppEvent,
                "appEventScreenshots" => AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.AppEventScreenshots,
                "appEventVideoClips" => AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.AppEventVideoClips,
                "locale" => AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.Locale,
                "longDescription" => AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.LongDescription,
                "name" => AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.Name,
                "placements" => AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.Placements,
                "shortDescription" => AppAssetLibraryPlacementsGetInstanceFieldsAppEventLocalization.ShortDescription,
                _ => null,
            };
        }
    }
}