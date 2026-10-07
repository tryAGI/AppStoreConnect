
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization
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
    public static class AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Description => "description",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Placements => "placements",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "placements" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Placements,
                "promotionalText" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppAssetLibraryVideosPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}