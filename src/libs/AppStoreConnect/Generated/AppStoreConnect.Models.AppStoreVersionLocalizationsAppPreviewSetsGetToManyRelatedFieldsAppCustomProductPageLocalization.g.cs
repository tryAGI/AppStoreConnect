
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization
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
    public static class AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.Locale => "locale",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.Placements => "placements",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.Locale,
                "placements" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.Placements,
                "promotionalText" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}