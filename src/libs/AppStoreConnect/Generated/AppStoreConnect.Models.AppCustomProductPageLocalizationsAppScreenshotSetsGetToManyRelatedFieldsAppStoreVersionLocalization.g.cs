
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization
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
    public static class AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Description => "description",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppCustomProductPageLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}