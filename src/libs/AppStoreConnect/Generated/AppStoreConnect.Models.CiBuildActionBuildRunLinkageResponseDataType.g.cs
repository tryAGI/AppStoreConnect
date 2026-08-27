
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiBuildActionBuildRunLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        CiBuildRuns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiBuildActionBuildRunLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiBuildActionBuildRunLinkageResponseDataType value)
        {
            return value switch
            {
                CiBuildActionBuildRunLinkageResponseDataType.CiBuildRuns => "ciBuildRuns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiBuildActionBuildRunLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "ciBuildRuns" => CiBuildActionBuildRunLinkageResponseDataType.CiBuildRuns,
                _ => null,
            };
        }
    }
}