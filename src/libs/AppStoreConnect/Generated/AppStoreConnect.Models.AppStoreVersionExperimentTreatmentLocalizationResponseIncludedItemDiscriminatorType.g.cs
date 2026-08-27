
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType
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
        AppStoreVersionExperimentTreatments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType.AppPreviewSets => "appPreviewSets",
                AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType.AppScreenshotSets,
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentTreatmentLocalizationResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments,
                _ => null,
            };
        }
    }
}