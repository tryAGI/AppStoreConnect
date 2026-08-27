
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization
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
    public static class AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.Locale => "locale",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.Locale,
                "promotionalText" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => AppCustomProductPageVersionsGetInstanceFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}