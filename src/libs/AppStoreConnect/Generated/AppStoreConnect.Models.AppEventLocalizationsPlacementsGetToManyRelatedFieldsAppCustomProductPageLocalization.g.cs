
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization
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
    public static class AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Locale => "locale",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Placements => "placements",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Locale,
                "placements" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Placements,
                "promotionalText" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}