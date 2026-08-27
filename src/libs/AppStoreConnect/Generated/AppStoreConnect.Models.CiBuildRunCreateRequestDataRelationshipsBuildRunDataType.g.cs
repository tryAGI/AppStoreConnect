
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildRunCreateRequestDataRelationshipsBuildRunDataType
    {
        /// <summary>
        ///
        /// </summary>
        CiBuildRuns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunCreateRequestDataRelationshipsBuildRunDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunCreateRequestDataRelationshipsBuildRunDataType value)
        {
            return value switch
            {
                CiBuildRunCreateRequestDataRelationshipsBuildRunDataType.CiBuildRuns => "ciBuildRuns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunCreateRequestDataRelationshipsBuildRunDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciBuildRuns" => CiBuildRunCreateRequestDataRelationshipsBuildRunDataType.CiBuildRuns,
                _ => null,
            };
        }
    }
}