
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum PreReleaseVersionsGetCollectionFilterPlatformItem
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
    public static class PreReleaseVersionsGetCollectionFilterPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PreReleaseVersionsGetCollectionFilterPlatformItem value)
        {
            return value switch
            {
                PreReleaseVersionsGetCollectionFilterPlatformItem.Ios => "IOS",
                PreReleaseVersionsGetCollectionFilterPlatformItem.MacOs => "MAC_OS",
                PreReleaseVersionsGetCollectionFilterPlatformItem.TvOs => "TV_OS",
                PreReleaseVersionsGetCollectionFilterPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PreReleaseVersionsGetCollectionFilterPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => PreReleaseVersionsGetCollectionFilterPlatformItem.Ios,
                "MAC_OS" => PreReleaseVersionsGetCollectionFilterPlatformItem.MacOs,
                "TV_OS" => PreReleaseVersionsGetCollectionFilterPlatformItem.TvOs,
                "VISION_OS" => PreReleaseVersionsGetCollectionFilterPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}