
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => AppCustomProductPageLocalizationInlineCreateRelationshipsAppCustomProductPageVersionDataType.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}