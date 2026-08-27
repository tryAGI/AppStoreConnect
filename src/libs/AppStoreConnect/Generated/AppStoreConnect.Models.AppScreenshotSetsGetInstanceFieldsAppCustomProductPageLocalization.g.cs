
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization
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
    public static class AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.Locale => "locale",
                AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.Locale,
                "promotionalText" => AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => AppScreenshotSetsGetInstanceFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}