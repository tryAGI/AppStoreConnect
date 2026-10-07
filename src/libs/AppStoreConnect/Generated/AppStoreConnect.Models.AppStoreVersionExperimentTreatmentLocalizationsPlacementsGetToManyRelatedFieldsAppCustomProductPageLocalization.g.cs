
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersion,
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
        Locale,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalizationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion => "appCustomProductPageVersion",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets => "appPreviewSets",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Locale => "locale",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Placements => "placements",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.PromotionalText => "promotionalText",
                AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.SearchKeywords => "searchKeywords",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersion" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppCustomProductPageVersion,
                "appPreviewSets" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.AppScreenshotSets,
                "locale" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Locale,
                "placements" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.Placements,
                "promotionalText" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.PromotionalText,
                "searchKeywords" => AppStoreVersionExperimentTreatmentLocalizationsPlacementsGetToManyRelatedFieldsAppCustomProductPageLocalization.SearchKeywords,
                _ => null,
            };
        }
    }
}