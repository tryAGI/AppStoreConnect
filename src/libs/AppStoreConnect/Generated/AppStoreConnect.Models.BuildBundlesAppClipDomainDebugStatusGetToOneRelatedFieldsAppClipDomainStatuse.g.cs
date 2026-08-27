
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse
    {
        /// <summary>
        /// 
        /// </summary>
        Domains,
        /// <summary>
        /// 
        /// </summary>
        LastUpdatedDate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse value)
        {
            return value switch
            {
                BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse.Domains => "domains",
                BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse.LastUpdatedDate => "lastUpdatedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse? ToEnum(string value)
        {
            return value switch
            {
                "domains" => BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse.Domains,
                "lastUpdatedDate" => BuildBundlesAppClipDomainDebugStatusGetToOneRelatedFieldsAppClipDomainStatuse.LastUpdatedDate,
                _ => null,
            };
        }
    }
}