
#nullable enable

namespace AppStoreConnect
{
    /// <summary>
    ///
    /// </summary>
    public enum BuildsGetCollectionFilterPreReleaseVersionPlatformItem
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
    public static class BuildsGetCollectionFilterPreReleaseVersionPlatformItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BuildsGetCollectionFilterPreReleaseVersionPlatformItem value)
        {
            return value switch
            {
                BuildsGetCollectionFilterPreReleaseVersionPlatformItem.Ios => "IOS",
                BuildsGetCollectionFilterPreReleaseVersionPlatformItem.MacOs => "MAC_OS",
                BuildsGetCollectionFilterPreReleaseVersionPlatformItem.TvOs => "TV_OS",
                BuildsGetCollectionFilterPreReleaseVersionPlatformItem.VisionOs => "VISION_OS",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BuildsGetCollectionFilterPreReleaseVersionPlatformItem? ToEnum(string value)
        {
            return value switch
            {
                "IOS" => BuildsGetCollectionFilterPreReleaseVersionPlatformItem.Ios,
                "MAC_OS" => BuildsGetCollectionFilterPreReleaseVersionPlatformItem.MacOs,
                "TV_OS" => BuildsGetCollectionFilterPreReleaseVersionPlatformItem.TvOs,
                "VISION_OS" => BuildsGetCollectionFilterPreReleaseVersionPlatformItem.VisionOs,
                _ => null,
            };
        }
    }
}