
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment
    {
        /// <summary>
        ///
        /// </summary>
        App,
        /// <summary>
        ///
        /// </summary>
        AppStoreVersion,
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
    public static class BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.App => "app",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.AppStoreVersion => "appStoreVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.EndDate => "endDate",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.Name => "name",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.Platform => "platform",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.StartDate => "startDate",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.State => "state",
                BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.App,
                "appStoreVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.Name,
                "platform" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.StartDate,
                "state" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => BuildsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}