
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment
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
    public static class ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.App => "app",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersion => "appStoreVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.EndDate => "endDate",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.Name => "name",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.Platform => "platform",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.StartDate => "startDate",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.State => "state",
                ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.App,
                "appStoreVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.Name,
                "platform" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.StartDate,
                "state" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => ReviewSubmissionsItemsGetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}