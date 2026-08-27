
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType
    {
        /// <summary>
        /// 
        /// </summary>
        AppCustomProductPages,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType value)
        {
            return value switch
            {
                AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType.AppCustomProductPages => "appCustomProductPages",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType? ToEnum(string value)
        {
            return value switch
            {
                "appCustomProductPages" => AppCustomProductPageVersionInlineCreateRelationshipsAppCustomProductPageDataType.AppCustomProductPages,
                _ => null,
            };
        }
    }
}