
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType value)
        {
            return value switch
            {
                AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatmentLocalizations" => AppPreviewSetRelationshipsAppStoreVersionExperimentTreatmentLocalizationDataType.AppStoreVersionExperimentTreatmentLocalizations,
                _ => null,
            };
        }
    }
}