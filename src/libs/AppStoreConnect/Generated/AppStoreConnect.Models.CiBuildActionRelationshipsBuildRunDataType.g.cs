
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildActionRelationshipsBuildRunDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CiBuildRuns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionRelationshipsBuildRunDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionRelationshipsBuildRunDataType value)
        {
            return value switch
            {
                CiBuildActionRelationshipsBuildRunDataType.CiBuildRuns => "ciBuildRuns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionRelationshipsBuildRunDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciBuildRuns" => CiBuildActionRelationshipsBuildRunDataType.CiBuildRuns,
                _ => null,
            };
        }
    }
}