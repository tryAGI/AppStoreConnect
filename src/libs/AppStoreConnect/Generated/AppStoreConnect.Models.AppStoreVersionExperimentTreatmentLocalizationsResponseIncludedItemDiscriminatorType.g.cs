
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType.AppPreviewSets => "appPreviewSets",
                AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType.AppScreenshotSets => "appScreenshotSets",
                AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType.AppPreviewSets,
                "appScreenshotSets" => AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType.AppScreenshotSets,
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentTreatmentLocalizationsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments,
                _ => null,
            };
        }
    }
}