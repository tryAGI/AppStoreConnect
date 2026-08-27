
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiWorkflowBuildRunsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        CiBuildRuns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiWorkflowBuildRunsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiWorkflowBuildRunsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiWorkflowBuildRunsLinkagesResponseDataItemType.CiBuildRuns => "ciBuildRuns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiWorkflowBuildRunsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciBuildRuns" => CiWorkflowBuildRunsLinkagesResponseDataItemType.CiBuildRuns,
                _ => null,
            };
        }
    }
}