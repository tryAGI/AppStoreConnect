
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization
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
    public static class AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Description => "description",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppStoreVersionLocalizationsAppPreviewSetsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}