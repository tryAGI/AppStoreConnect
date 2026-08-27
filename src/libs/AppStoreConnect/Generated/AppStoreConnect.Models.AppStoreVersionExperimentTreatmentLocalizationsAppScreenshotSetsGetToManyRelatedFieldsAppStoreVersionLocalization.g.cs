
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion => "appStoreVersion",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Description => "description",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords => "keywords",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale => "locale",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl => "marketingUrl",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText => "promotionalText",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords => "searchKeywords",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl => "supportUrl",
                AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew => "whatsNew",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppScreenshotSets,
                "appStoreVersion" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.AppStoreVersion,
                "description" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Description,
                "keywords" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Keywords,
                "locale" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.Locale,
                "marketingUrl" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.MarketingUrl,
                "promotionalText" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.PromotionalText,
                "searchKeywords" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SearchKeywords,
                "supportUrl" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.SupportUrl,
                "whatsNew" => AppStoreVersionExperimentTreatmentLocalizationsAppScreenshotSetsGetToManyRelatedFieldsAppStoreVersionLocalization.WhatsNew,
                _ => null,
            };
        }
    }
}