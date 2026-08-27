
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatments,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppStoreVersionExperimentResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionExperimentResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments,
                "appStoreVersions" => AppStoreVersionExperimentResponseIncludedItemDiscriminatorType.AppStoreVersions,
                _ => null,
            };
        }
    }
}