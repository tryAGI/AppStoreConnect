
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunRelationshipsProductDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CiProducts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunRelationshipsProductDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunRelationshipsProductDataType value)
        {
            return value switch
            {
                CiBuildRunRelationshipsProductDataType.CiProducts => "ciProducts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunRelationshipsProductDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciProducts" => CiBuildRunRelationshipsProductDataType.CiProducts,
                _ => null,
            };
        }
    }
}