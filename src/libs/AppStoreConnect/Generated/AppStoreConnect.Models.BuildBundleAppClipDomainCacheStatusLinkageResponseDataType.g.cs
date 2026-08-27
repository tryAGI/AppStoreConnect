
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBundleAppClipDomainCacheStatusLinkageResponseDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDomainStatuses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleAppClipDomainCacheStatusLinkageResponseDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleAppClipDomainCacheStatusLinkageResponseDataType value)
        {
            return value switch
            {
                BuildBundleAppClipDomainCacheStatusLinkageResponseDataType.AppClipDomainStatuses => "appClipDomainStatuses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleAppClipDomainCacheStatusLinkageResponseDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDomainStatuses" => BuildBundleAppClipDomainCacheStatusLinkageResponseDataType.AppClipDomainStatuses,
                _ => null,
            };
        }
    }
}