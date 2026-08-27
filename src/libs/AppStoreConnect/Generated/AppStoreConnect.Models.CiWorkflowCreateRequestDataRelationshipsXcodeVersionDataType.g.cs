
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CiXcodeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType value)
        {
            return value switch
            {
                CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType.CiXcodeVersions => "ciXcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciXcodeVersions" => CiWorkflowCreateRequestDataRelationshipsXcodeVersionDataType.CiXcodeVersions,
                _ => null,
            };
        }
    }
}