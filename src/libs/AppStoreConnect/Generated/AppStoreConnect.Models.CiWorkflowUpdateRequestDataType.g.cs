
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowUpdateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CiWorkflows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowUpdateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowUpdateRequestDataType value)
        {
            return value switch
            {
                CiWorkflowUpdateRequestDataType.CiWorkflows => "ciWorkflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowUpdateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciWorkflows" => CiWorkflowUpdateRequestDataType.CiWorkflows,
                _ => null,
            };
        }
    }
}