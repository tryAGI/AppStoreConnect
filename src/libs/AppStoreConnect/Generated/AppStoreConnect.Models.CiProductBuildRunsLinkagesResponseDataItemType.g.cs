
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum CiProductBuildRunsLinkagesResponseDataItemType
    {
        /// <summary>
        ///
        /// </summary>
        CiBuildRuns,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CiProductBuildRunsLinkagesResponseDataItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CiProductBuildRunsLinkagesResponseDataItemType value)
        {
            return value switch
            {
                CiProductBuildRunsLinkagesResponseDataItemType.CiBuildRuns => "ciBuildRuns",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CiProductBuildRunsLinkagesResponseDataItemType? ToEnum(string value)
        {
            return value switch
            {
                "ciBuildRuns" => CiProductBuildRunsLinkagesResponseDataItemType.CiBuildRuns,
                _ => null,
            };
        }
    }
}