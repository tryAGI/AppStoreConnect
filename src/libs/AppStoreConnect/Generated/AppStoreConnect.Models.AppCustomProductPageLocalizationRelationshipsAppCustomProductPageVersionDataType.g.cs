
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPageVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType value)
        {
            return value switch
            {
                AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType.AppCustomProductPageVersions => "appCustomProductPageVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPageVersions" => AppCustomProductPageLocalizationRelationshipsAppCustomProductPageVersionDataType.AppCustomProductPageVersions,
                _ => null,
            };
        }
    }
}