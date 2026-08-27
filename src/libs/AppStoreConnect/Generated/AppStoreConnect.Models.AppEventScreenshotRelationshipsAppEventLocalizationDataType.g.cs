
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppEventScreenshotRelationshipsAppEventLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppEventLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventScreenshotRelationshipsAppEventLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventScreenshotRelationshipsAppEventLocalizationDataType value)
        {
            return value switch
            {
                AppEventScreenshotRelationshipsAppEventLocalizationDataType.AppEventLocalizations => "appEventLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventScreenshotRelationshipsAppEventLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalizations" => AppEventScreenshotRelationshipsAppEventLocalizationDataType.AppEventLocalizations,
                _ => null,
            };
        }
    }
}