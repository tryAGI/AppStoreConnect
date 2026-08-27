
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowRelationshipsProductDataType
    {
        /// <summary>
        ///
        /// </summary>
        CiProducts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowRelationshipsProductDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowRelationshipsProductDataType value)
        {
            return value switch
            {
                CiWorkflowRelationshipsProductDataType.CiProducts => "ciProducts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowRelationshipsProductDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciProducts" => CiWorkflowRelationshipsProductDataType.CiProducts,
                _ => null,
            };
        }
    }
}