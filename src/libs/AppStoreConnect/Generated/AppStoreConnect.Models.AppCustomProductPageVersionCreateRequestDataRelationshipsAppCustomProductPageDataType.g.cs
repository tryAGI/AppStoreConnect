
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageDataType value)
        {
            return value switch
            {
                AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageDataType.AppCustomProductPages => "appCustomProductPages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPages" => AppCustomProductPageVersionCreateRequestDataRelationshipsAppCustomProductPageDataType.AppCustomProductPages,
                _ => null,
            };
        }
    }
}