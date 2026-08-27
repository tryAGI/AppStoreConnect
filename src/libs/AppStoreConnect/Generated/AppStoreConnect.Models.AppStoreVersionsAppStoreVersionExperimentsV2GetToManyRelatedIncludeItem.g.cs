
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionExperimentTreatments,
        /// <summary>
        ///
        /// </summary>
        ControlVersions,
        /// <summary>
        ///
        /// </summary>
        LatestControlVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.App => "app",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.ControlVersions => "controlVersions",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.LatestControlVersion => "latestControlVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.App,
                "appStoreVersionExperimentTreatments" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.ControlVersions,
                "latestControlVersion" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.LatestControlVersion,
                _ => null,
            };
        }
    }
}