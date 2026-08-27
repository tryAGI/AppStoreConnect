
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunCreateRequestDataRelationshipsWorkflowDataType
    {
        /// <summary>
        ///
        /// </summary>
        CiWorkflows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunCreateRequestDataRelationshipsWorkflowDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunCreateRequestDataRelationshipsWorkflowDataType value)
        {
            return value switch
            {
                CiBuildRunCreateRequestDataRelationshipsWorkflowDataType.CiWorkflows => "ciWorkflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunCreateRequestDataRelationshipsWorkflowDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciWorkflows" => CiBuildRunCreateRequestDataRelationshipsWorkflowDataType.CiWorkflows,
                _ => null,
            };
        }
    }
}