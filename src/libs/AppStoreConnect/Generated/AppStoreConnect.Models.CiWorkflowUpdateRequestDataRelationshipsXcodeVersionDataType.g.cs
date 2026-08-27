
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        CiXcodeVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType value)
        {
            return value switch
            {
                CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType.CiXcodeVersions => "ciXcodeVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciXcodeVersions" => CiWorkflowUpdateRequestDataRelationshipsXcodeVersionDataType.CiXcodeVersions,
                _ => null,
            };
        }
    }
}