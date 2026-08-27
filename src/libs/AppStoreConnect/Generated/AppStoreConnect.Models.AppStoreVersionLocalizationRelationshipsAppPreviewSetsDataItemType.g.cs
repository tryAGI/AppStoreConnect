
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        AppPreviewSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType.AppPreviewSets => "appPreviewSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionLocalizationRelationshipsAppPreviewSetsDataItemType.AppPreviewSets,
                _ => null,
            };
        }
    }
}