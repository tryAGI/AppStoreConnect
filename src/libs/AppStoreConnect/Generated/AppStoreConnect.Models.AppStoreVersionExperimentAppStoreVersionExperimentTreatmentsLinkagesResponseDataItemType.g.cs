
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentAppStoreVersionExperimentTreatmentsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentTreatments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentAppStoreVersionExperimentTreatmentsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentAppStoreVersionExperimentTreatmentsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionExperimentAppStoreVersionExperimentTreatmentsLinkagesResponseDataItemType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentAppStoreVersionExperimentTreatmentsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentAppStoreVersionExperimentTreatmentsLinkagesResponseDataItemType.AppStoreVersionExperimentTreatments,
                _ => null,
            };
        }
    }
}