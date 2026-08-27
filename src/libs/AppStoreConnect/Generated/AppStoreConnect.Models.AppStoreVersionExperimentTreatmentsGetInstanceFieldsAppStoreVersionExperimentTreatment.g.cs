
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment
    {
        /// <summary>
        /// 
        /// </summary>
        AppIcon,
        /// <summary>
        /// 
        /// </summary>
        AppIconName,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperiment,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentTreatmentLocalizations,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentV2,
        /// <summary>
        /// 
        /// </summary>
        Name,
        /// <summary>
        /// 
        /// </summary>
        PromotedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIcon => "appIcon",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIconName => "appIconName",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment => "appStoreVersionExperiment",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.Name => "name",
                AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.PromotedDate => "promotedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment? ToEnum(string value)
        {
            return value switch
            {
                "appIcon" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIcon,
                "appIconName" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIconName,
                "appStoreVersionExperiment" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment,
                "appStoreVersionExperimentTreatmentLocalizations" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionExperimentV2" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2,
                "name" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.Name,
                "promotedDate" => AppStoreVersionExperimentTreatmentsGetInstanceFieldsAppStoreVersionExperimentTreatment.PromotedDate,
                _ => null,
            };
        }
    }
}