
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization
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
    public static class AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Description => "description",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Placements => "placements",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "placements" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Placements,
                "promotionalText" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppStoreVersionLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}