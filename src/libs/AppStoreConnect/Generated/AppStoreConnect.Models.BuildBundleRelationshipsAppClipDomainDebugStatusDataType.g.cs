
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildBundleRelationshipsAppClipDomainDebugStatusDataType
    {
        /// <summary>
        ///
        /// </summary>
        AppClipDomainStatuses,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundleRelationshipsAppClipDomainDebugStatusDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundleRelationshipsAppClipDomainDebugStatusDataType value)
        {
            return value switch
            {
                BuildBundleRelationshipsAppClipDomainDebugStatusDataType.AppClipDomainStatuses => "appClipDomainStatuses",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundleRelationshipsAppClipDomainDebugStatusDataType? ToEnum(string value)
        {
            return value switch
            {
                "appClipDomainStatuses" => BuildBundleRelationshipsAppClipDomainDebugStatusDataType.AppClipDomainStatuses,
                _ => null,
            };
        }
    }
}