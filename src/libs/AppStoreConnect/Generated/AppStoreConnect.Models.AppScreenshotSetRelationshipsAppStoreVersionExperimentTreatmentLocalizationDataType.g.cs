
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType value)
        {
            return value switch
            {
                AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatmentLocalizations" => AppScreenshotSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType.AppStoreVersionExperimentTreatmentLocalizations,
                _ => null,
            };
        }
    }
}