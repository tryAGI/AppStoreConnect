
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment
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
    public static class GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.App => "app",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.AppStoreVersion => "appStoreVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.EndDate => "endDate",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.Name => "name",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.Platform => "platform",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.StartDate => "startDate",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.State => "state",
                GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.App,
                "appStoreVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.Name,
                "platform" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.StartDate,
                "state" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => GameCenterAppVersionsAppStoreVersionGetToOneRelatedFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}