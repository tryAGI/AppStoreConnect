
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBundleAppClipDomainDebugStatusLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDomainStatuses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleAppClipDomainDebugStatusLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleAppClipDomainDebugStatusLinkageResponseDataType value)
        {
            return value switch
            {
                BuildBundleAppClipDomainDebugStatusLinkageResponseDataType.AppClipDomainStatuses => "appClipDomainStatuses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleAppClipDomainDebugStatusLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDomainStatuses" => BuildBundleAppClipDomainDebugStatusLinkageResponseDataType.AppClipDomainStatuses,
                _ => null,
            };
        }
    }
}