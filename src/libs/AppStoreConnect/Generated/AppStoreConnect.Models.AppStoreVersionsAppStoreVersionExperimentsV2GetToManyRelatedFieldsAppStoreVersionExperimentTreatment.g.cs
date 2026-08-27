
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment
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
    public static class AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatmentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment value)
        {
            return value switch
            {
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppIcon => "appIcon",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppIconName => "appIconName",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment => "appStoreVersionExperiment",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.Name => "name",
                AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.PromotedDate => "promotedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment? ToEnum(string value)
        {
            return value switch
            {
                "appIcon" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppIcon,
                "appIconName" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppIconName,
                "appStoreVersionExperiment" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperiment,
                "appStoreVersionExperimentTreatmentLocalizations" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionExperimentV2" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.AppStoreVersionExperimentV2,
                "name" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.Name,
                "promotedDate" => AppStoreVersionsAppStoreVersionExperimentsV2GetToManyRelatedFieldsAppStoreVersionExperimentTreatment.PromotedDate,
                _ => null,
            };
        }
    }
}