
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBundleRelationshipsAppClipDomainCacheStatusDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDomainStatuses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleRelationshipsAppClipDomainCacheStatusDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleRelationshipsAppClipDomainCacheStatusDataType value)
        {
            return value switch
            {
                BuildBundleRelationshipsAppClipDomainCacheStatusDataType.AppClipDomainStatuses => "appClipDomainStatuses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleRelationshipsAppClipDomainCacheStatusDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDomainStatuses" => BuildBundleRelationshipsAppClipDomainCacheStatusDataType.AppClipDomainStatuses,
                _ => null,
            };
        }
    }
}