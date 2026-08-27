
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFieldsAppStoreVersionExperiment
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
    public static class AppsGetCollectionFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppsGetCollectionFieldsAppStoreVersionExperiment.App => "app",
                AppsGetCollectionFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppsGetCollectionFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                AppsGetCollectionFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppsGetCollectionFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                AppsGetCollectionFieldsAppStoreVersionExperiment.Name => "name",
                AppsGetCollectionFieldsAppStoreVersionExperiment.Platform => "platform",
                AppsGetCollectionFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppsGetCollectionFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppsGetCollectionFieldsAppStoreVersionExperiment.State => "state",
                AppsGetCollectionFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetCollectionFieldsAppStoreVersionExperiment.App,
                "appStoreVersionExperimentTreatments" => AppsGetCollectionFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppsGetCollectionFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => AppsGetCollectionFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => AppsGetCollectionFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => AppsGetCollectionFieldsAppStoreVersionExperiment.Name,
                "platform" => AppsGetCollectionFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => AppsGetCollectionFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppsGetCollectionFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppsGetCollectionFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppsGetCollectionFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}