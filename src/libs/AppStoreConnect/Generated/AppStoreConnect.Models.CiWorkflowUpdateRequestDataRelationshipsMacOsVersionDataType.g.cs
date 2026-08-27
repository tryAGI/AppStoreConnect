
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        CiMacOsVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType value)
        {
            return value switch
            {
                CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType.CiMacOsVersions => "ciMacOsVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciMacOsVersions" => CiWorkflowUpdateRequestDataRelationshipsMacOsVersionDataType.CiMacOsVersions,
                _ => null,
            };
        }
    }
}