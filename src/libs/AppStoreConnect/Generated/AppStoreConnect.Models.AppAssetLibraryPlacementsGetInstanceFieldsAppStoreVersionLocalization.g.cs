
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization
    {
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
        AppStoreVersion,
        /// <summary>
        ///
        /// </summary>
        Description,
        /// <summary>
        ///
        /// </summary>
        Keywords,
        /// <summary>
        ///
        /// </summary>
        Locale,
        /// <summary>
        ///
        /// </summary>
        MarketingUrl,
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
        /// <summary>
        ///
        /// </summary>
        SupportUrl,
        /// <summary>
        ///
        /// </summary>
        WhatsNew,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.Description => "description",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.Locale => "locale",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.Placements => "placements",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.MarketingUrl,
                "placements" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.Placements,
                "promotionalText" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppAssetLibraryPlacementsGetInstanceFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}