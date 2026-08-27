
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppEventLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType value)
        {
            return value switch
            {
                AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType.AppEventLocalizations => "appEventLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appEventLocalizations" => AppEventScreenshotCreateRequestDataRelationshipsAppEventLocalizationDataType.AppEventLocalizations,
                _ => null,
            };
        }
    }
}