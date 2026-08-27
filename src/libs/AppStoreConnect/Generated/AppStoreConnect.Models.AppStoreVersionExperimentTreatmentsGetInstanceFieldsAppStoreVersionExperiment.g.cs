
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment
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
    public static class AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.App => "app",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersion => "appStoreVersion",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.Name => "name",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.Platform => "platform",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.State => "state",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.App,
                "appStoreVersion" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.Name,
                "platform" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}