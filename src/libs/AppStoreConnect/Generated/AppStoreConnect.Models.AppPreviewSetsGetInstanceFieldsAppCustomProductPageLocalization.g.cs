
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization
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
    public static class AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.Locale => "locale",
                AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.Locale,
                "promotionalText" => AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => AppPreviewSetsGetInstanceFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}