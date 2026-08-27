
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentV2ResponseIncludedItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentTreatments,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersions,
        /// <summary>
        /// 
        /// </summary>
        Apps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentV2ResponseIncludedItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentV2ResponseIncludedItemDiscriminatorType value)
        {
            return value switch
            {
                AppStoreVersionExperimentV2ResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionExperimentV2ResponseIncludedItemDiscriminatorType.AppStoreVersions => "appStoreVersions",
                AppStoreVersionExperimentV2ResponseIncludedItemDiscriminatorType.Apps => "apps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentV2ResponseIncludedItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentV2ResponseIncludedItemDiscriminatorType.AppStoreVersionExperimentTreatments,
                "appStoreVersions" => AppStoreVersionExperimentV2ResponseIncludedItemDiscriminatorType.AppStoreVersions,
                "apps" => AppStoreVersionExperimentV2ResponseIncludedItemDiscriminatorType.Apps,
                _ => null,
            };
        }
    }
}