
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppPreviewSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType.AppPreviewSets => "appPreviewSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionExperimentTreatmentLocalizationRelationshipsAppPreviewSetsDataItemType.AppPreviewSets,
                _ => null,
            };
        }
    }
}