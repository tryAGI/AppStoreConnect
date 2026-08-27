
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationAppPreviewSetsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviewSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationAppPreviewSetsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationAppPreviewSetsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationAppPreviewSetsLinkagesResponseDataItemType.AppPreviewSets => "appPreviewSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationAppPreviewSetsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionExperimentTreatmentLocalizationAppPreviewSetsLinkagesResponseDataItemType.AppPreviewSets,
                _ => null,
            };
        }
    }
}