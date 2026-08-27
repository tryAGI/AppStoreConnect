
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageLocalizationCreateRequestDataRelationshipsAppCustomProductPageVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationCreateRequestDataRelationshipsAppCustomProductPageVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationCreateRequestDataRelationshipsAppCustomProductPageVersionDataType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationCreateRequestDataRelationshipsAppCustomProductPageVersionDataType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationCreateRequestDataRelationshipsAppCustomProductPageVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => AppCustomProductPageLocalizationCreateRequestDataRelationshipsAppCustomProductPageVersionDataType.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}