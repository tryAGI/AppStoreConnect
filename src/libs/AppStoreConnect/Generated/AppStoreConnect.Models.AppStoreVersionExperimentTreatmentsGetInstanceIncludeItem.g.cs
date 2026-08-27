
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem
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
    public static class AppStoreVersionExperimentTreatmentsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem.AppStoreVersionExperiment => "appStoreVersionExperiment",
                AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem.AppStoreVersionExperimentTreatmentLocalizations => "appStoreVersionExperimentTreatmentLocalizations",
                AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem.AppStoreVersionExperimentV2 => "appStoreVersionExperimentV2",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperiment" => AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem.AppStoreVersionExperiment,
                "appStoreVersionExperimentTreatmentLocalizations" => AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem.AppStoreVersionExperimentTreatmentLocalizations,
                "appStoreVersionExperimentV2" => AppStoreVersionExperimentTreatmentsGetInstanceIncludeItem.AppStoreVersionExperimentV2,
                _ => null,
            };
        }
    }
}