
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType
    {
        /// <summary>
        ///
        /// </summary>
        CiMacOsVersions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType value)
        {
            return value switch
            {
                CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType.CiMacOsVersions => "ciMacOsVersions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciMacOsVersions" => CiWorkflowCreateRequestDataRelationshipsMacOsVersionDataType.CiMacOsVersions,
                _ => null,
            };
        }
    }
}