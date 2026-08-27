
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem
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
    public static class AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperiment => "appStoreVersionExperiment",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiment" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperiment,
                "appStoreVersionExperimentTreatmentLocalizations" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionExperimentV2" => AppStoreVersionExperimentsAppStoreVersionExperimentTreatmentsGetToManyRelatedIncludeItem.AppStoreVersionExperimentV2,
                _ => null,
            };
        }
    }
}