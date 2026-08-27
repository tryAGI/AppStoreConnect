
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment
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
    public static class AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIcon => "appIcon",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIconName => "appIconName",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment => "appStoreVersionExperiment",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.Name => "name",
                AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.PromotedDate => "promotedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment? ToEnum(string value)
        {
            return value switch
            {
                "appIcon" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIcon,
                "appIconName" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppIconName,
                "appStoreVersionExperiment" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment,
                "appStoreVersionExperimentTreatmentLocalizations" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionExperimentV2" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2,
                "name" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.Name,
                "promotedDate" => AppStoreVersionExperimentTreatmentLocalizationsGetInstanceFieldsAppStoreVersionExperimentTreatment.PromotedDate,
                _ => null,
            };
        }
    }
}