
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment
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
    public static class AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment value)
        {
            return value switch
            {
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.AppIcon => "appIcon",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.AppIconName => "appIconName",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment => "appStoreVersionExperiment",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.Name => "name",
                AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.PromotedDate => "promotedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment? ToEnum(string value)
        {
            return value switch
            {
                "appIcon" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.AppIcon,
                "appIconName" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.AppIconName,
                "appStoreVersionExperiment" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment,
                "appStoreVersionExperimentTreatmentLocalizations" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionExperimentV2" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2,
                "name" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.Name,
                "promotedDate" => AppStoreVersionExperimentsV2GetInstanceFieldsAppStoreVersionExperimentTreatment.PromotedDate,
                _ => null,
            };
        }
    }
}