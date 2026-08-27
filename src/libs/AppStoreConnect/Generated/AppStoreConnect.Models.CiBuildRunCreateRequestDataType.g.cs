
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum CiBuildRunCreateRequestDataType
    {
        /// <summary>
        /// 
        /// </summary>
        CiBuildRuns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildRunCreateRequestDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildRunCreateRequestDataType value)
        {
            return value switch
            {
                CiBuildRunCreateRequestDataType.CiBuildRuns => "ciBuildRuns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildRunCreateRequestDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciBuildRuns" => CiBuildRunCreateRequestDataType.CiBuildRuns,
                _ => null,
            };
        }
    }
}