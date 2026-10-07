
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersion,
        /// <summary>
        ///
        /// </summary>
        AppPreviewSets,
        /// <summary>
        ///
        /// </summary>
        AppScreenshotSets,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        Placements,
        /// <summary>
        ///
        /// </summary>
        PromotionalText,
        /// <summary>
        ///
        /// </summary>
        SearchKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.Locale => "locale",
                AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.Placements => "placements",
                AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.Locale,
                "placements" => AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.Placements,
                "promotionalText" => AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => AppAssetLibraryPlacementsGetInstanceFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}