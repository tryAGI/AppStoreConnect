
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment
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
    public static class AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.App => "app",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersion => "appStoreVersion",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.Name => "name",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.Platform => "platform",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.State => "state",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.App,
                "appStoreVersion" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.Name,
                "platform" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}