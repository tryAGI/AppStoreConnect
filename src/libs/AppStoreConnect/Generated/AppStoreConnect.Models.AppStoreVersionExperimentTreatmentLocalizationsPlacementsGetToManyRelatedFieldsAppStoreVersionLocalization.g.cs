
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Description => "description",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Placements => "placements",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "placements" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.Placements,
                "promotionalText" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}