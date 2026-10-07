
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization
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
    public static class AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Locale => "locale",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Placements => "placements",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Locale,
                "placements" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Placements,
                "promotionalText" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}