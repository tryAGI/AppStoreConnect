
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunRelationshipsWorkflowDataType
    {
        /// <summary>
        ///
        /// </summary>
        CiWorkflows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunRelationshipsWorkflowDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunRelationshipsWorkflowDataType value)
        {
            return value switch
            {
                CiBuildRunRelationshipsWorkflowDataType.CiWorkflows => "ciWorkflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunRelationshipsWorkflowDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciWorkflows" => CiBuildRunRelationshipsWorkflowDataType.CiWorkflows,
                _ => null,
            };
        }
    }
}