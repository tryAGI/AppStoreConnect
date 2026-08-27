
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentTreatmentType.AppStoreVersionExperimentTreatments,
                _ => null,
            };
        }
    }
}