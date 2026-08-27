
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowCreateRequestDataRelationshipsProductDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CiProducts,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowCreateRequestDataRelationshipsProductDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowCreateRequestDataRelationshipsProductDataType value)
        {
            return value switch
            {
                CiWorkflowCreateRequestDataRelationshipsProductDataType.CiProducts => "ciProducts",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowCreateRequestDataRelationshipsProductDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciProducts" => CiWorkflowCreateRequestDataRelationshipsProductDataType.CiProducts,
                _ => null,
            };
        }
    }
}