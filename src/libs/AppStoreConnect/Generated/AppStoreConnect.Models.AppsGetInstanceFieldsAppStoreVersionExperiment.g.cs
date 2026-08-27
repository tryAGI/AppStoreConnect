
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsGetInstanceFieldsAppStoreVersionExperiment
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
    public static class AppsGetInstanceFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetInstanceFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppsGetInstanceFieldsAppStoreVersionExperiment.App => "app",
                AppsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppsGetInstanceFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                AppsGetInstanceFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppsGetInstanceFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                AppsGetInstanceFieldsAppStoreVersionExperiment.Name => "name",
                AppsGetInstanceFieldsAppStoreVersionExperiment.Platform => "platform",
                AppsGetInstanceFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppsGetInstanceFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppsGetInstanceFieldsAppStoreVersionExperiment.State => "state",
                AppsGetInstanceFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetInstanceFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsGetInstanceFieldsAppStoreVersionExperiment.App,
                "appStoreVersionExperimentTreatments" => AppsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppsGetInstanceFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => AppsGetInstanceFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => AppsGetInstanceFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => AppsGetInstanceFieldsAppStoreVersionExperiment.Name,
                "platform" => AppsGetInstanceFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => AppsGetInstanceFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppsGetInstanceFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppsGetInstanceFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppsGetInstanceFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}