
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageLocalizations,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType value)
        {
            return value switch
            {
                AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType.AppCustomProductPageLocalizations => "appCustomProductPageLocalizations",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageLocalizations" => AppPreviewSetRelationshipsAppCustomProductPageLocalizationDataType.AppCustomProductPageLocalizations,
                _ => null,
            };
        }
    }
}