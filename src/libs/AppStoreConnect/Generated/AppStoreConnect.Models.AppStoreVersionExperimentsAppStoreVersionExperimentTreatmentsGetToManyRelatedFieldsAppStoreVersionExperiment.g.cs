
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment
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
    public static class AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.App => "app",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersion => "appStoreVersion",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.Name => "name",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.Platform => "platform",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.State => "state",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.App,
                "appStoreVersion" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.Name,
                "platform" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}