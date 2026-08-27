
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment
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
    public static class AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppIcon => "appIcon",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppIconName => "appIconName",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment => "appStoreVersionExperiment",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.Name => "name",
                AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.PromotedDate => "promotedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment? ToEnum(string value)
        {
            return value switch
            {
                "appIcon" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppIcon,
                "appIconName" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppIconName,
                "appStoreVersionExperiment" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment,
                "appStoreVersionExperimentTreatmentLocalizations" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionExperimentV2" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2,
                "name" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.Name,
                "promotedDate" => AppStoreVersionsAppStoreVersionExperimentsGetToManyRelatedFieldsAppStoreVersionExperimentTreatment.PromotedDate,
                _ => null,
            };
        }
    }
}