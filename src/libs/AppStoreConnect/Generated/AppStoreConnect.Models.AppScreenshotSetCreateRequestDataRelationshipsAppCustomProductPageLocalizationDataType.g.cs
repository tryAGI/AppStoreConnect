
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType value)
        {
            return value switch
            {
                AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppScreenshotSetCreateRequestDataRelationshipsAppCustomProductPageLocalizationDataType.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}