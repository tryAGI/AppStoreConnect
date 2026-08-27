
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppRelationshipsCiProductDataType
    {
        /// <summary>
        ///
        /// </summary>
        CiProducts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppRelationshipsCiProductDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppRelationshipsCiProductDataType value)
        {
            return value switch
            {
                AppRelationshipsCiProductDataType.CiProducts => "ciProducts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppRelationshipsCiProductDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciProducts" => AppRelationshipsCiProductDataType.CiProducts,
                _ => null,
            };
        }
    }
}