
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatments,
                _ => null,
            };
        }
    }
}