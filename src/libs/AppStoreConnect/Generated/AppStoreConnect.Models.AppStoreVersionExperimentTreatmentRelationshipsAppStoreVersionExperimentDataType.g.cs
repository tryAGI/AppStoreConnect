
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentDataType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}