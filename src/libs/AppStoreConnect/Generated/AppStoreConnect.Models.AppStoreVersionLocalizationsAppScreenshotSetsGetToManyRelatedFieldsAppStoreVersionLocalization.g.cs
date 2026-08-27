
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization
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
    public static class AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Description => "description",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppStoreVersionLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}