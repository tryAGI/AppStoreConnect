
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment
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
    public static class AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersion => "appStoreVersion",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.Name => "name",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.State => "state",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "endDate" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.EndDate,
                "name" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.Name,
                "reviewRequired" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}