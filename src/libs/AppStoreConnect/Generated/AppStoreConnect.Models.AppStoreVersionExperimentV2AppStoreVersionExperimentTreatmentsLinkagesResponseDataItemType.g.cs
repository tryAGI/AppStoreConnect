
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentV2AppStoreVersionExperimentTreatmentsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppStoreVersionExperimentTreatments,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentV2AppStoreVersionExperimentTreatmentsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentV2AppStoreVersionExperimentTreatmentsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionExperimentV2AppStoreVersionExperimentTreatmentsLinkagesResponseDataItemType.AppStoreVersionExperimentTreatments => "appStoreVersionExperimentTreatments",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentV2AppStoreVersionExperimentTreatmentsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionExperimentTreatments" => AppStoreVersionExperimentV2AppStoreVersionExperimentTreatmentsLinkagesResponseDataItemType.AppStoreVersionExperimentTreatments,
                _ => null,
            };
        }
    }
}