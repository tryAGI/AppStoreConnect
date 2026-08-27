
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReviewSubmissionsGetCollectionFilterPlatformItem
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
    public static class ReviewSubmissionsGetCollectionFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReviewSubmissionsGetCollectionFilterPlatformItem value)
        {
            return value switch
            {
                ReviewSubmissionsGetCollectionFilterPlatformItem.Ios => "IOS",
                ReviewSubmissionsGetCollectionFilterPlatformItem.MacOs => "MAC_OS",
                ReviewSubmissionsGetCollectionFilterPlatformItem.TvOs => "TV_OS",
                ReviewSubmissionsGetCollectionFilterPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReviewSubmissionsGetCollectionFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => ReviewSubmissionsGetCollectionFilterPlatformItem.Ios,
                "MAC_OS" => ReviewSubmissionsGetCollectionFilterPlatformItem.MacOs,
                "TV_OS" => ReviewSubmissionsGetCollectionFilterPlatformItem.TvOs,
                "VISION_OS" => ReviewSubmissionsGetCollectionFilterPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}