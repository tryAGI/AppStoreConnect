
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment
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
    public static class AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.App => "app",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersion => "appStoreVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.EndDate => "endDate",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.Name => "name",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.Platform => "platform",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.StartDate => "startDate",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.State => "state",
                AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.App,
                "appStoreVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.Name,
                "platform" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.StartDate,
                "state" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => AppsAppStoreVersionsGetToManyRelatedFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}