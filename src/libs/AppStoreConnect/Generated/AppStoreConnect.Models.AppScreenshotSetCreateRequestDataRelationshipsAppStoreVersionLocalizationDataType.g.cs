
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppScreenshotSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppStoreVersionLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType value)
        {
            return value switch
            {
                AppScreenshotSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType.AppStoreVersionLocalizations => "appStoreVersionLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appStoreVersionLocalizations" => AppScreenshotSetCreateRequestDataRelationshipsAppStoreVersionLocalizationDataType.AppStoreVersionLocalizations,
                _ => null,
            };
        }
    }
}