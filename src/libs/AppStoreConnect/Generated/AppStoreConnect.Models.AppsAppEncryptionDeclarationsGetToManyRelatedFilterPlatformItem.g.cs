
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem
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
    public static class AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem value)
        {
            return value switch
            {
                AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem.Ios => "IOS",
                AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem.MacOs => "MAC_OS",
                AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem.TvOs => "TV_OS",
                AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem.Ios,
                "MAC_OS" => AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem.MacOs,
                "TV_OS" => AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem.TvOs,
                "VISION_OS" => AppsAppEncryptionDeclarationsGetToManyRelatedFilterPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}