
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment
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
    public static class CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment value)
        {
            return value switch
            {
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.App => "app",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.ControlVersions => "controlVersions",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.EndDate => "endDate",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.LatestControlVersion => "latestControlVersion",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.Name => "name",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.Platform => "platform",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.ReviewRequired => "reviewRequired",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.StartDate => "startDate",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.State => "state",
                CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.TrafficProportion => "trafficProportion",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment? ToEnum(string value)
        {
            return value switch
            {
                "app" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.App,
                "appStoreVersionExperimentTreatments" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.AppStoreVersionExperimentTreatments,
                "controlVersions" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.ControlVersions,
                "endDate" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.EndDate,
                "latestControlVersion" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.LatestControlVersion,
                "name" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.Name,
                "platform" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.Platform,
                "reviewRequired" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.ReviewRequired,
                "startDate" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.StartDate,
                "state" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.State,
                "trafficProportion" => CiProductsAppGetToOneRelatedFieldsAppStoreVersionExperiment.TrafficProportion,
                _ => null,
            };
        }
    }
}