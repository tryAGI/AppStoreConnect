
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum AppsGetCollectionFilterAppStoreVersionsPlatformItem
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
    public static class AppsGetCollectionFilterAppStoreVersionsPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AppsGetCollectionFilterAppStoreVersionsPlatformItem value)
        {
            return value switch
            {
                AppsGetCollectionFilterAppStoreVersionsPlatformItem.Ios => "IOS",
                AppsGetCollectionFilterAppStoreVersionsPlatformItem.MacOs => "MAC_OS",
                AppsGetCollectionFilterAppStoreVersionsPlatformItem.TvOs => "TV_OS",
                AppsGetCollectionFilterAppStoreVersionsPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AppsGetCollectionFilterAppStoreVersionsPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => AppsGetCollectionFilterAppStoreVersionsPlatformItem.Ios,
                "MAC_OS" => AppsGetCollectionFilterAppStoreVersionsPlatformItem.MacOs,
                "TV_OS" => AppsGetCollectionFilterAppStoreVersionsPlatformItem.TvOs,
                "VISION_OS" => AppsGetCollectionFilterAppStoreVersionsPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}