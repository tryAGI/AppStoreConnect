
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppEncryptionDeclarationsGetCollectionFilterPlatformItem
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
    public static class AppEncryptionDeclarationsGetCollectionFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppEncryptionDeclarationsGetCollectionFilterPlatformItem value)
        {
            return value switch
            {
                AppEncryptionDeclarationsGetCollectionFilterPlatformItem.Ios => "IOS",
                AppEncryptionDeclarationsGetCollectionFilterPlatformItem.MacOs => "MAC_OS",
                AppEncryptionDeclarationsGetCollectionFilterPlatformItem.TvOs => "TV_OS",
                AppEncryptionDeclarationsGetCollectionFilterPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppEncryptionDeclarationsGetCollectionFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppEncryptionDeclarationsGetCollectionFilterPlatformItem.Ios,
                "MAC_OS" => AppEncryptionDeclarationsGetCollectionFilterPlatformItem.MacOs,
                "TV_OS" => AppEncryptionDeclarationsGetCollectionFilterPlatformItem.TvOs,
                "VISION_OS" => AppEncryptionDeclarationsGetCollectionFilterPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}