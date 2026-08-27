
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentsV2GetInstanceIncludeItem
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
    public static class AppStoreVersionExperimentsV2GetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsV2GetInstanceIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionExperimentsV2GetInstanceIncludeItem.App => "app",
                AppStoreVersionExperimentsV2GetInstanceIncludeItem.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionExperimentsV2GetInstanceIncludeItem.ControlVersions => "controlVersions",
                AppStoreVersionExperimentsV2GetInstanceIncludeItem.LatestControlVersion => "latestControlVersion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsV2GetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppStoreVersionExperimentsV2GetInstanceIncludeItem.App,
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentsV2GetInstanceIncludeItem.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppStoreVersionExperimentsV2GetInstanceIncludeItem.ControlVersions,
                "latestControlVersion" => AppStoreVersionExperimentsV2GetInstanceIncludeItem.LatestControlVersion,
                _ => null,
            };
        }
    }
}