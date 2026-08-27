
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppStoreVersionLocalizationAppPreviewSetsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviewSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppStoreVersionLocalizationAppPreviewSetsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppStoreVersionLocalizationAppPreviewSetsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppStoreVersionLocalizationAppPreviewSetsLinkagesResponseDataItemType.AppPreviewSets => "appPreviewSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppStoreVersionLocalizationAppPreviewSetsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppStoreVersionLocalizationAppPreviewSetsLinkagesResponseDataItemType.AppPreviewSets,
                _ => null,
            };
        }
    }
}