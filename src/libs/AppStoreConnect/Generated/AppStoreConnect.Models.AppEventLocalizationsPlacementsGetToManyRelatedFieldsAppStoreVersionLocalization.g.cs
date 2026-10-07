
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization
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
        Placements,
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
    public static class AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Description => "description",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Placements => "placements",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "placements" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Placements,
                "promotionalText" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppEventLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}