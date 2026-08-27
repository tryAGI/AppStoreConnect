
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization
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
        PromotionalText,
        /// <summary>
        ///
        /// </summary>
        SearchKeywords,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.Locale => "locale",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.Locale,
                "promotionalText" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => AppCustomProductPageLocalizationsGetInstanceFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}