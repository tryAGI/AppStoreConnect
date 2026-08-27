
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => AppStoreVersionExperimentTreatmentCreateRequestDataRelationshipsAppStoreVersionExperimentDataType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}