
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization
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
    public static class AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Description => "description",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Placements => "placements",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "placements" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Placements,
                "promotionalText" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppAssetLibraryImagesPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}