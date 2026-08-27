
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentsGetInstanceIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersion,
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentTreatments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentsGetInstanceIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentsGetInstanceIncludeItem value)
        {
            return value switch
            {
                AppStoreVersionExperimentsGetInstanceIncludeItem.AppStoreVersion => "appStoreVersion",
                AppStoreVersionExperimentsGetInstanceIncludeItem.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentsGetInstanceIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersion" => AppStoreVersionExperimentsGetInstanceIncludeItem.AppStoreVersion,
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentsGetInstanceIncludeItem.AppStoreVersionExperimentTreatments,
                _ => null,
            };
        }
    }
}