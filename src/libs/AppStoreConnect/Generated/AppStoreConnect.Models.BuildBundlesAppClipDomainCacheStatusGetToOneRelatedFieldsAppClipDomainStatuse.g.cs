
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse
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
    public static class BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse value)
        {
            return value switch
            {
                BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse.Domains => "domains",
                BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse.LastUpdatedDate => "lastUpdatedDate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse? ToEnum(string value)
        {
            return value switch
            {
                "domains" => BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse.Domains,
                "lastUpdatedDate" => BuildBundlesAppClipDomainCacheStatusGetToOneRelatedFieldsAppClipDomainStatuse.LastUpdatedDate,
                _ => null,
            };
        }
    }
}