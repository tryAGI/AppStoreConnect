
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiWorkflowRelationshipsMacOsVersionDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CiMacOsVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowRelationshipsMacOsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowRelationshipsMacOsVersionDataType value)
        {
            return value switch
            {
                CiWorkflowRelationshipsMacOsVersionDataType.CiMacOsVersions => "ciMacOsVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowRelationshipsMacOsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciMacOsVersions" => CiWorkflowRelationshipsMacOsVersionDataType.CiMacOsVersions,
                _ => null,
            };
        }
    }
}