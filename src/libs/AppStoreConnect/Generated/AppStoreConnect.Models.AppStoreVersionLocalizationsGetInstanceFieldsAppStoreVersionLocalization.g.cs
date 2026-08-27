
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization
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
    public static class AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.Description => "description",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.Locale => "locale",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppStoreVersionLocalizationsGetInstanceFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}