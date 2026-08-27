
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppScreenshotSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType.AppScreenshotSets => "appScreenshotSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSets" => AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppScreenshotSetsDataItemType.AppScreenshotSets,
                _ => null,
            };
        }
    }
}