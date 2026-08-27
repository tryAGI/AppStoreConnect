
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment
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
    public static class AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment value)
        {
            return value switch
            {
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIcon => "appIcon",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIconName => "appIconName",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment => "appStoreVersionExperiment",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.Name => "name",
                AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.PromotedDate => "promotedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment? ToEnum(string value)
        {
            return value switch
            {
                "appIcon" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIcon,
                "appIconName" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIconName,
                "appStoreVersionExperiment" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment,
                "appStoreVersionExperimentTreatmentLocalizations" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionExperimentV2" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2,
                "name" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.Name,
                "promotedDate" => AppStoreVersionExperimentsGetInstanceFieldsAppStoreVersionExperimentTreatment.PromotedDate,
                _ => null,
            };
        }
    }
}