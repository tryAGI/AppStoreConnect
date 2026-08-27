
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization
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
    public static class AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.Description => "description",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.Locale => "locale",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppStoreVersionsGetInstanceFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}