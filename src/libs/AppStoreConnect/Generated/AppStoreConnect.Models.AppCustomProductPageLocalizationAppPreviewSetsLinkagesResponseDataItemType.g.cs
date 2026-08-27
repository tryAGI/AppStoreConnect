
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageLocalizationAppPreviewSetsLinkagesResponseDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppPreviewSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationAppPreviewSetsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationAppPreviewSetsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationAppPreviewSetsLinkagesResponseDataItemType.AppPreviewSets => "appPreviewSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationAppPreviewSetsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appPreviewSets" => AppCustomProductPageLocalizationAppPreviewSetsLinkagesResponseDataItemType.AppPreviewSets,
                _ => null,
            };
        }
    }
}