
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowRelationshipsXcodeVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CiXcodeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowRelationshipsXcodeVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowRelationshipsXcodeVersionDataType value)
        {
            return value switch
            {
                CiWorkflowRelationshipsXcodeVersionDataType.CiXcodeVersions => "ciXcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowRelationshipsXcodeVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciXcodeVersions" => CiWorkflowRelationshipsXcodeVersionDataType.CiXcodeVersions,
                _ => null,
            };
        }
    }
}