
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType
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
    public static class AppStoreVersionExperimentsResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments,
                "appStoreVersions" => AppStoreVersionExperimentsResponseIncludedItemDiscriminatorType.AppStoreVersions,
                _ => null,
            };
        }
    }
}