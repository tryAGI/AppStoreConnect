
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization
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
    public static class AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.Description => "description",
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.Locale => "locale",
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppScreenshotSetsGetInstanceFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}