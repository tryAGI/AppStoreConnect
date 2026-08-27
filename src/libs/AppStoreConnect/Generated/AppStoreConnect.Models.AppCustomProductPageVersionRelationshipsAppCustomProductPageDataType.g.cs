
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppCustomProductPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageVersionRelationshipsAppCustomProductPageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType value)
        {
            return value switch
            {
                AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType.AppCustomProductPages => "appCustomProductPages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPages" => AppCustomProductPageVersionRelationshipsAppCustomProductPageDataType.AppCustomProductPages,
                _ => null,
            };
        }
    }
}