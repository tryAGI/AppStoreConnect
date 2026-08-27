
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment
    {
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
        EndDate,
        /// <summary>
        /// 
        /// </summary>
        Name,
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
    public static class AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersion => "appStoreVersion",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.Name => "name",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.State => "state",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "endDate" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.EndDate,
                "name" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.Name,
                "reviewRequired" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}