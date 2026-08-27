
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CiWorkflows,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowCreateRequestDataType value)
        {
            return value switch
            {
                CiWorkflowCreateRequestDataType.CiWorkflows => "ciWorkflows",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciWorkflows" => CiWorkflowCreateRequestDataType.CiWorkflows,
                _ => null,
            };
        }
    }
}