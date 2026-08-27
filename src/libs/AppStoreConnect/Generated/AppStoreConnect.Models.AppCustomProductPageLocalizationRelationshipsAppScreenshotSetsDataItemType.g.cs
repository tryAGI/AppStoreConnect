
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType
    {
        /// <summary>
        /// 
        /// </summary>
        AppScreenshotSets,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType.AppScreenshotSets => "appScreenshotSets",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "appScreenshotSets" => AppCustomProductPageLocalizationRelationshipsAppScreenshotSetsDataItemType.AppScreenshotSets,
                _ => null,
            };
        }
    }
}