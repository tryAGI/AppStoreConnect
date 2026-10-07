
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization
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
    public static class AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Locale => "locale",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Placements => "placements",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Locale,
                "placements" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Placements,
                "promotionalText" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => AppCustomProductPageLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}