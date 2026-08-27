
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperiments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType.AppStoreVersionExperiments => "appStoreVersionExperiments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiments" => AppStoreVersionExperimentTreatmentRelationshipsAppStoreVersionExperimentV2DataType.AppStoreVersionExperiments,
                _ => null,
            };
        }
    }
}