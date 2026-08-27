
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization
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
    public static class AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Description => "description",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppCustomProductPageLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}