
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment
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
    public static class AppStoreVersionsGetInstanceFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.App => "app",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.Name => "name",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.Platform => "platform",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.State => "state",
                AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.App,
                "appStoreVersion" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.Name,
                "platform" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppStoreVersionsGetInstanceFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}