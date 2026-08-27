
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization
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
    public static class AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.Description => "description",
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.Locale => "locale",
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppPreviewSetsGetInstanceFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}