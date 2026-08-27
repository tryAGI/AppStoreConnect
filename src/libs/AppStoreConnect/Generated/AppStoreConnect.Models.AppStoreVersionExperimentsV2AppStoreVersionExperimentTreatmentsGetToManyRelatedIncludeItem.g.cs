
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperiment => "appStoreVersionExperiment",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiment" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperiment,
                "appStoreVersionExperimentTreatmentLocalizations" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionExperimentV2" => AppStoreVersionExperimentsV2AppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperimentV2,
                _ => null,
            };
        }
    }
}