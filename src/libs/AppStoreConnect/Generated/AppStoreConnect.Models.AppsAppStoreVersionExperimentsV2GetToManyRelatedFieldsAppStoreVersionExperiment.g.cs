
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment
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
    public static class AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.App => "app",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.Name => "name",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.Platform => "platform",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.State => "state",
                AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.App,
                "appStoreVersionExperimentTreatments" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.Name,
                "platform" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}