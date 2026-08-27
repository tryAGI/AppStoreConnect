
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem
    {
        /// <summary>
        /// 
        /// </summary>
        Ios,
        /// <summary>
        /// 
        /// </summary>
        MacOs,
        /// <summary>
        /// 
        /// </summary>
        TvOs,
        /// <summary>
        /// 
        /// </summary>
        VisionOs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AppsAppStoreVersionsGetToManyRelatedFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem value)
        {
            return value switch
            {
                AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem.Ios => "IOS",
                AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem.MacOs => "MAC_OS",
                AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem.TvOs => "TV_OS",
                AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem.Ios,
                "MAC_OS" => AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem.MacOs,
                "TV_OS" => AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem.TvOs,
                "VISION_OS" => AppsAppStoreVersionsGetToManyRelatedFilterPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}