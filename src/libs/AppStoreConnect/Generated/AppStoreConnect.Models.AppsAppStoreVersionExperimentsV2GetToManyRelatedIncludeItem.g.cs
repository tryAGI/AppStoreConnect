
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem
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
    public static class AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.App => "app",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.ControlVersions => "controlVersions",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.LatestControlVersion => "latestControlVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.App,
                "appStoreVersionExperimentTreatments" => AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.ControlVersions,
                "latestControlVersion" => AppsAppStoreVersionExperimentsV2GetToManyRelatedIncludeItem.LatestControlVersion,
                _ => null,
            };
        }
    }
}