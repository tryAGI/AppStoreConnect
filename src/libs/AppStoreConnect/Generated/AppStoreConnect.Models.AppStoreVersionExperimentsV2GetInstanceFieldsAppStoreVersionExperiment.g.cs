
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment
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
        EndDate,
        /// <summary>
        ///
        /// </summary>
        LatestControlVersion,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        Platform,
        /// <summary>
        ///
        /// </summary>
        ReviewRequired,
        /// <summary>
        ///
        /// </summary>
        StartDate,
        /// <summary>
        ///
        /// </summary>
        State,
        /// <summary>
        ///
        /// </summary>
        TrafficProportion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.App => "app",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.Name => "name",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.Platform => "platform",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.State => "state",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.App,
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.Name,
                "platform" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}